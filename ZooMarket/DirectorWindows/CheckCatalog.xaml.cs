using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using ZooMarket.EmployeWindows;

namespace ZooMarket.DirectorWindows
{
    public partial class CheckCatalog : Window
    {
        private ObservableCollection<ProductViewModel> productsCollection;
        private CollectionViewSource productsViewSource;
        private ZooMarketEntities1 db;

        public CheckCatalog()
        {
            InitializeComponent();
            db = new ZooMarketEntities1();
            LoadProducts();
        }

        private void LoadProducts()
        {
     
            var categories = db.КатегорииТоваров.Select(c => c.Наименование).Distinct().ToList();
            FilterCategoryComboBox.ItemsSource = categories;
            FilterCategoryComboBox.SelectedIndex = -1; 

            var productTypes = db.ТипТовара.Select(pt => pt.Наименование).Distinct().ToList();
            FilterProductTypeComboBox.ItemsSource = productTypes;
            FilterProductTypeComboBox.SelectedIndex = -1; 

            var products = db.Товары.Select(p => new
            {
                Название = p.Название,
                ТоварID = p.ТоварID
            }).ToList();
            FilterNameComboBox.ItemsSource = products;
            FilterNameComboBox.DisplayMemberPath = "Название";
            FilterNameComboBox.SelectedValuePath = "ТоварID";
            FilterNameComboBox.SelectedIndex = -1; 

            var productsData = db.Товары.ToList();
            var typesData = db.ТипТовара.ToList();
            var categoriesData = db.КатегорииТоваров.ToList();

            var productsViewModels = productsData
                .Select(p => new ProductViewModel
                {
                    Название = p.Название,
                    Описание = p.Описание,
                    Цена = (decimal)p.Цена,
                    Количество = (int)p.Количество,
                    СрокГодности = (DateTime)p.СрокГодности,
                    ТипТовара = typesData.FirstOrDefault(t => t.ТипТовараID == p.ТипТовара)?.Наименование ?? "Неизвестный тип товара",
                    Категория = categoriesData.FirstOrDefault(c => c.КатегорияID == p.КатегорияID)?.Наименование ?? "Неизвестная категория"
                })
                .ToList();

            productsCollection = new ObservableCollection<ProductViewModel>(productsViewModels);

            productsViewSource = new CollectionViewSource { Source = productsCollection };
            productsViewSource.SortDescriptions.Add(new SortDescription("Название", ListSortDirection.Ascending));

            ProductsDataGrid.ItemsSource = productsViewSource.View;
        }

        private void ProductsDataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            var product = e.Row.Item as ProductViewModel;
            if (product != null)
            {
              
                if (product.Количество < 5 || product.СрокГодности < DateTime.Now.AddDays(5))
                {
                    e.Row.Background = Brushes.Red; 
                }
                else
                {
                    e.Row.Background = Brushes.White; 
                }
            }
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Director director = new Director();
            director.Show();
            this.Close();
        }

        private void ApplyFilterButton_Click(object sender, RoutedEventArgs e)
        {
            string nameFilter = FilterNameComboBox.SelectedItem?.ToString();
            string categoryFilter = FilterCategoryComboBox.Text.Trim();
            string productTypeFilter = FilterProductTypeComboBox.Text.Trim();

            var filteredCollection = productsCollection.Where(product =>
                (string.IsNullOrEmpty(nameFilter) || product.Название == nameFilter) &&
                (string.IsNullOrEmpty(categoryFilter) || product.Категория == categoryFilter) &&
                (string.IsNullOrEmpty(productTypeFilter) || product.ТипТовара == productTypeFilter)
            ).ToList();

            productsViewSource.Source = filteredCollection;
            ProductsDataGrid.ItemsSource = productsViewSource.View;
        }

        private void FilterNameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ApplyFilterButton_Click(sender, e);
        }
    }

    public class ProductViewModel
    {
        public string Название { get; set; }
        public string Описание { get; set; }
        public decimal Цена { get; set; }
        public int Количество { get; set; }
        public DateTime СрокГодности { get; set; }
        public string ТипТовара { get; set; }
        public string Категория { get; set; }
    }
}