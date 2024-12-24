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
using ZooMarket.EmployeWindows;
namespace ZooMarket.EmployeWindows
{
    public partial class EmployeSaleReport : Window
    {
        private ZooMarketEntities1 db;
        private int? currentEmployeeId;

        public EmployeSaleReport()
        {
            InitializeComponent();
            db = new ZooMarketEntities1();
            currentEmployeeId = Application.Current.Properties["CurrentEmployeeId"] as int?;
            LoadSales();
            LoadDates();
            LoadSales();

        }

        

        private void LoadDates()
        {
            var dates = db.Продажи.Select(s => s.Дата).Distinct().OrderBy(d => d).ToList();
            FilterDateComboBox.ItemsSource = dates;
        }

        private void LoadSales()
        {
            var sales = db.Продажи
                .Join(db.Сотрудники, s => s.СотрудникID, e => e.СотрудникID, (s, e) => new
                {
                    ФИО = e.ФИО,
                    Дата = s.Дата,
                    Сумма = s.Сумма,
                    СотрудникID = e.СотрудникID 
                });

            if (currentEmployeeId.HasValue)
            {
                sales = sales.Where(s => s.СотрудникID == currentEmployeeId.Value);
            }

            var filteredSales = sales.ToList();

            SalesDataGrid.ItemsSource = filteredSales;

            decimal totalSales = (decimal)filteredSales.Sum(s => s.Сумма);
            TotalSalesTextBlock.Text = $"Общая сумма продаж: {totalSales}";
        }

        private void ApplyFilterButton_Click(object sender, RoutedEventArgs e)
        {
            FilterSales();
        }

        private void FilterEmployeeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FilterSales();
        }

        private void FilterDateComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FilterSales();
        }

        private void FilterSales()
        {
            DateTime? selectedDate = FilterDateComboBox.SelectedItem as DateTime?;

            var sales = db.Продажи
                .Join(db.Сотрудники, s => s.СотрудникID, e => e.СотрудникID, (s, e) => new
                {
                    ФИО = e.ФИО,
                    Дата = s.Дата,
                    Сумма = s.Сумма,
                    СотрудникID = e.СотрудникID 
                });

            if (currentEmployeeId.HasValue)
            {
                sales = sales.Where(s => s.СотрудникID == currentEmployeeId.Value);
            }


            if (selectedDate.HasValue)
            {
                sales = sales.Where(s => s.Дата == selectedDate.Value);
            }

            var filteredSales = sales.ToList();

            SalesDataGrid.ItemsSource = filteredSales;

            decimal totalSales = (decimal)filteredSales.Sum(s => s.Сумма);
            TotalSalesTextBlock.Text = $"Общая сумма продаж: {totalSales}";
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Employe employe = new Employe();
            employe.Show();
            this.Close();
        }
    }
}