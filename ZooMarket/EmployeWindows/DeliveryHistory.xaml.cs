using System;
using System.Collections.Generic;
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

namespace ZooMarket.EmployeWindows
{
    public partial class DeliveryHistory : Window
    {
        ZooMarketEntities1 db = new ZooMarketEntities1();

        public DeliveryHistory()
        {
            InitializeComponent();
            LoadProducts();
            LoadDeliveryHistory();
        }

        private void LoadProducts()
        {
            var products = db.Товары.ToList();
            FilterProductComboBox.ItemsSource = products;
        }

        private void LoadDeliveryHistory()
        {
            var deliveries = db.Поставки
                .Join(db.СоставПоставки, p => p.ПоставкаID, sp => sp.ПоставкаID, (p, sp) => new
                {
                    ПоставкаID = p.ПоставкаID,
                    НазваниеТовара = sp.Товары.Название,
                    Количество = sp.Количество,
                    ДатаПоставки = p.ДатаПоставки
                })
                .ToList();

            DeliveryDataGrid.ItemsSource = deliveries;
        }

        private void ApplyFilterButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedProduct = FilterProductComboBox.SelectedItem as Товары;
            DateTime? dateFilter = FilterDatePicker.SelectedDate;

            var filteredDeliveries = db.Поставки
                .Join(db.СоставПоставки, p => p.ПоставкаID, sp => sp.ПоставкаID, (p, sp) => new
                {
                    ПоставкаID = p.ПоставкаID,
                    НазваниеТовара = sp.Товары.Название,
                    Количество = sp.Количество,
                    ДатаПоставки = p.ДатаПоставки
                })
                .Where(d => (selectedProduct == null || d.НазваниеТовара == selectedProduct.Название)
                         && (!dateFilter.HasValue || d.ДатаПоставки == dateFilter.Value))
                .ToList();

            DeliveryDataGrid.ItemsSource = filteredDeliveries;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Employe employe = new Employe();
            employe.Show();
            this.Close();
        }
    }
}