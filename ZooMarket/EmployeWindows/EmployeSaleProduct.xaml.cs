using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Application = Microsoft.Office.Interop.Word.Application;
using System.IO;
using System.Diagnostics;
namespace ZooMarket.EmployeWindows
{
    public partial class EmployeSaleProduct : System.Windows.Window
    {
        private ZooMarketEntities1 db;
        private List<SaleProductViewModel> saleProducts = new List<SaleProductViewModel>();

        public EmployeSaleProduct()
        {
            InitializeComponent();
            db = new ZooMarketEntities1();
            LoadCategories();
        }

        private void LoadCategories()
        {
            var categories = db.ТипТовара.ToList();
            CategoryComboBox.ItemsSource = categories;
            CategoryComboBox.DisplayMemberPath = "Наименование";
            CategoryComboBox.SelectedValuePath = "ТипТовараID";
        }

        private void CategoryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CategoryComboBox.SelectedItem is ТипТовара selectedCategory)
            {
                var products = db.Товары.Where(p => p.ТипТовара == selectedCategory.ТипТовараID).ToList();
                ProductComboBox.ItemsSource = products;
                ProductComboBox.DisplayMemberPath = "Название";
                ProductComboBox.SelectedValuePath = "ТоварID";
            }
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            if (ProductComboBox.SelectedItem is Товары selectedProduct && int.TryParse(QuantityTextBox.Text, out int quantity))
            {
                if (quantity > 0 && quantity <= selectedProduct.Количество)
                {
                    var saleProduct = new SaleProductViewModel
                    {
                        Название = selectedProduct.Название,
                        Количество = quantity
                    };

                    saleProducts.Add(saleProduct);
                    SaleProductsDataGrid.ItemsSource = saleProducts;
                    SaleProductsDataGrid.Items.Refresh();

                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Недостаточно товара для продажи.");
                }
            }
            else
            {
                MessageBox.Show("Введите корректное количество товара.");
            }
        }

        private void SellButton_Click(object sender, RoutedEventArgs e)
        {
            if (saleProducts.Count > 0)
            {
                decimal totalPrice = 0;

                var sale = new Продажи
                {
                    СотрудникID = GetCurrentEmployeeId(),
                    Дата = DateTime.Now,
                    Сумма = 0 
                };
                db.Продажи.Add(sale);
                db.SaveChanges(); 

                foreach (var saleProduct in saleProducts)
                {
                    var product = db.Товары.FirstOrDefault(p => p.Название == saleProduct.Название);
                    if (product != null)
                    {
                        totalPrice += (decimal)(product.Цена * saleProduct.Количество);

                       
                        product.Количество -= saleProduct.Количество;

                      
                        var saleDetails = new СоставПродажи
                        {
                            ПродажаID = sale.ПродажаID, 
                            ТоварID = product.ТоварID,
                            Количество = saleProduct.Количество
                        };
                        db.СоставПродажи.Add(saleDetails);
                    }
                }

                sale.Сумма = totalPrice;
                db.SaveChanges();

                GenerateReceipt((DateTime)sale.Дата, totalPrice, saleProducts);

                MessageBox.Show($"Товары успешно проданы. Общая сумма: {totalPrice}");
                saleProducts.Clear();
                SaleProductsDataGrid.ItemsSource = saleProducts;
                SaleProductsDataGrid.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Добавьте товары для продажи.");
            }
        }

        private void ClearFields()
        {
            CategoryComboBox.SelectedIndex = -1;
            ProductComboBox.SelectedIndex = -1;
            QuantityTextBox.Text = "";
        }

        private int GetCurrentEmployeeId()
        {
            return 1; 
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Employe employe = new Employe();
            employe.Show();
            this.Close();
        }


        private void GenerateReceipt(DateTime saleDate, decimal totalAmount, List<SaleProductViewModel> saleProducts)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = $"Чек_продажи_{saleDate:yyyyMMdd_HHmmss}.docx";
            string filePath = System.IO.Path.Combine(desktopPath, fileName);

            Application wordApp = new Application();
            Document wordDoc = wordApp.Documents.Add();

            Range headerRange = wordDoc.Range(0, 0);
            headerRange.Text = "Чек о продаже\n\n";
            headerRange.Font.Bold = 1;
            headerRange.Font.Size = 16;
            headerRange.InsertParagraphAfter();

            Range dateRange = wordDoc.Range(headerRange.End, headerRange.End);
            dateRange.Text = $"Дата продажи: {saleDate:dd.MM.yyyy HH:mm}\n";
            dateRange.Font.Size = 12;
            dateRange.InsertParagraphAfter();

            Range productsRange = wordDoc.Range(dateRange.End, dateRange.End);
            productsRange.Text = "Товары:\n";
            productsRange.Font.Size = 12;
            productsRange.InsertParagraphAfter();

            foreach (var product in saleProducts)
            {
                Range productRange = wordDoc.Range(productsRange.End, productsRange.End);
                productRange.Text = $"{product.Название} - {product.Количество} шт. - {product.Количество * db.Товары.First(t => t.Название == product.Название).Цена:C}\n";
                productRange.Font.Size = 12;
                productRange.InsertParagraphAfter();
            }

            Range totalRange = wordDoc.Range(productsRange.End, productsRange.End);
            totalRange.Text = $"\nОбщая сумма: {totalAmount:C}\n";
            totalRange.Font.Bold = 1;
            totalRange.Font.Size = 14;
            totalRange.InsertParagraphAfter();

            wordDoc.SaveAs2(filePath);
            wordDoc.Close();
            wordApp.Quit();

            Process.Start(filePath);

            MessageBox.Show($"Чек успешно сохранён и открыт: {fileName}");
        }


    }

    public class SaleProductViewModel
    {
        public string Название { get; set; }
        public int Количество { get; set; }
    }
}