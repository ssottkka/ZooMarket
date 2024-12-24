using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace ZooMarket.EmployeWindows
{
    public partial class EmployeCatalogCheck : Window
    {
        private ObservableCollection<ProductViewModel> productsCollection;
        private CollectionViewSource productsViewSource;
        private ZooMarketEntities1 db;

        public EmployeCatalogCheck()
        {
            InitializeComponent();
            db = new ZooMarketEntities1();
            LoadProducts();
            LoadFilters();
        }

        private void LoadProducts()
        {
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

        private void LoadFilters()
        {
            var types = db.ТипТовара.ToList();
            FilterTypeComboBox.ItemsSource = types;

            var categories = db.КатегорииТоваров.ToList();
            FilterCategoryComboBox.ItemsSource = categories;
        }

        private void ApplyFilterButton_Click(object sender, RoutedEventArgs e)
        {
            productsViewSource.Filter += ApplyFilters;
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

        private void ApplyFilters(object sender, FilterEventArgs e)
        {
            var product = e.Item as ProductViewModel;
            if (product == null) return;
            if (FilterTypeComboBox.SelectedItem is ТипТовара selectedType)
            {
                if (!product.ТипТовара.Equals(selectedType.Наименование))
                {
                    e.Accepted = false;
                    return;
                }
            }

            if (FilterCategoryComboBox.SelectedItem is КатегорииТоваров selectedCategory)
            {
                if (!product.Категория.Equals(selectedCategory.Наименование))
                {
                    e.Accepted = false;
                    return;
                }
            }
        }

       

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Employe employe = new Employe();
            employe.Show();
            this.Close();
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