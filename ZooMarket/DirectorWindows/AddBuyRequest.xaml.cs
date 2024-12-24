using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Application = Microsoft.Office.Interop.Word.Application;

namespace ZooMarket.DirectorWindows
{
    public partial class AddBuyRequest : System.Windows.Window
    {
        private ZooMarketEntities1 db;
        private List<SelectedProduct> selectedProducts = new List<SelectedProduct>();

        public AddBuyRequest()
        {
            InitializeComponent();
            db = new ZooMarketEntities1();
            LoadSuppliers();
            LoadProductTypes();
        }

        private void LoadSuppliers()
        {
            var suppliers = db.Поставщики.ToList();
            SupplierComboBox.ItemsSource = suppliers;
        }

        private void LoadProductTypes()
        {
            var productTypes = db.ТипТовара.ToList();
            ProductTypeComboBox.ItemsSource = productTypes;
        }

        private void ProductTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProductTypeComboBox.SelectedItem is ТипТовара selectedProductType)
            {
                var products = db.Товары.Where(t => t.ТипТовара == selectedProductType.ТипТовараID).ToList();
                ProductComboBox.ItemsSource = products;
            }
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            if (ProductComboBox.SelectedItem is Товары selectedProduct && int.TryParse(QuantityTextBox.Text, out int quantity))
            {
                selectedProducts.Add(new SelectedProduct
                {
                    Товар = selectedProduct,
                    Количество = quantity
                });

                SelectedProductsDataGrid.ItemsSource = selectedProducts.Select(p => new
                {
                    Название = p.Товар.Название,
                    Количество = p.Количество
                }).ToList();
                SelectedProductsDataGrid.Items.Refresh();

                ProductComboBox.SelectedIndex = -1;
                QuantityTextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Выберите товар и укажите количество.");
            }
        }

        private void CreateRequestButton_Click(object sender, RoutedEventArgs e)
        {
            if (SupplierComboBox.SelectedItem is Поставщики selectedSupplier && selectedProducts.Any())
            {
                var заявка = new ЗаявкиНаПокупку
                {
                    ПоставщикID = selectedSupplier.ПоставщикID,
                    Статус = 2 
                };
                db.ЗаявкиНаПокупку.Add(заявка);
                db.SaveChanges();

                foreach (var selectedProduct in selectedProducts)
                {
                    var составЗаявки = new СоставЗаявки
                    {
                        ЗаявкиID = заявка.ЗаявкаID,
                        ТоварID = selectedProduct.Товар.ТоварID,
                        Количество = selectedProduct.Количество
                    };
                    db.СоставЗаявки.Add(составЗаявки);
                }
                db.SaveChanges();

                GenerateRequestDocument(selectedSupplier, selectedProducts);

                MessageBox.Show("Заявка на покупку успешно создана.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите поставщика и добавьте товары.");
            }
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Director director = new Director();
            director.Show();
            this.Close();
        }

        private void GenerateRequestDocument(Поставщики supplier, List<SelectedProduct> products)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = $"Заявка_на_покупку_{DateTime.Now:yyyyMMdd_HHmmss}.docx";
            string filePath = System.IO.Path.Combine(desktopPath, fileName);

            Application wordApp = new Application();
            Document wordDoc = wordApp.Documents.Add();

            Range headerRange = wordDoc.Range(0, 0);
            headerRange.Text = "Заявка на покупку\n\n";
            headerRange.Font.Bold = 1;
            headerRange.Font.Size = 16;
            headerRange.InsertParagraphAfter();

            Range supplierRange = wordDoc.Range(headerRange.End, headerRange.End);
            supplierRange.Text = $"Поставщик: {supplier.Название}\n";
            supplierRange.Text += $"Контактное лицо: {supplier.КонтактноеЛицо}\n\n";
            supplierRange.Font.Size = 12;
            supplierRange.InsertParagraphAfter();

            Range productsRange = wordDoc.Range(supplierRange.End, supplierRange.End);
            productsRange.Text = "Товары:\n";
            productsRange.Font.Size = 12;
            productsRange.InsertParagraphAfter();

            decimal totalPrice = 0;
            foreach (var product in products)
            {
                decimal productPrice = (decimal)(product.Товар.Цена * product.Количество);
                totalPrice += productPrice;

                Range productRange = wordDoc.Range(productsRange.End, productsRange.End);
                productRange.Text = $"{product.Товар.Название} - {product.Количество} шт. - {productPrice:C}\n";
                productRange.Font.Size = 12;
                productRange.InsertParagraphAfter();
            }

            Range totalRange = wordDoc.Range(productsRange.End, productsRange.End);
            totalRange.Text = $"\nОбщая сумма: {totalPrice:C}\n";
            totalRange.Font.Bold = 1;
            totalRange.Font.Size = 14;
            totalRange.InsertParagraphAfter();

            wordDoc.SaveAs2(filePath);
            wordDoc.Close();
            wordApp.Quit();

            Process.Start(filePath);

            MessageBox.Show($"Заявка успешно сохранена и открыта: {fileName}");
        }
    }

    public class SelectedProduct
    {
        public Товары Товар { get; set; }
        public int Количество { get; set; }
    }
}