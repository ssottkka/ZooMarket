using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using ZooMarket;

namespace ZooMarket
{
    public partial class AdminCheckUsers : Window
    {
        private ObservableCollection<EmployeeViewModel> employeesCollection;
        private CollectionViewSource employeesViewSource;
        private ZooMarketEntities1 db;

        public AdminCheckUsers()
        {
            InitializeComponent();
            db = new ZooMarketEntities1();
            LoadEmployees();
            ResetFilters();
        }

        private void LoadEmployees()
        {
            // Заполнение ComboBox должностей
            var positions = db.Должности.Select(p => p.Наименование).Distinct().ToList();
            FilterPositionComboBox.ItemsSource = positions;
            FilterPositionComboBox.SelectedIndex = -1; // Сброс выбора

            // Заполнение ComboBox ФИО сотрудников
            var employees = db.Сотрудники.Select(e => new EmployeeViewModel
            {
                ФИО = e.ФИО,
                ДатаПриема = (DateTime)e.ДатаПриема,
                Зарплата = (decimal)e.Зарплата,
                Должность = (db.Должности.FirstOrDefault(p => p.ДолжностьID == e.ДолжностьID) != null)
    ? db.Должности.FirstOrDefault(p => p.ДолжностьID == e.ДолжностьID).Наименование
    : "Неизвестная должность",
                Логин = e.Логин
            }).ToList();

            // Создание ObservableCollection для привязки к DataGrid
            employeesCollection = new ObservableCollection<EmployeeViewModel>(employees);

            // Создание CollectionViewSource для сортировки
            employeesViewSource = new CollectionViewSource { Source = employeesCollection };
            employeesViewSource.SortDescriptions.Add(new SortDescription("ФИО", ListSortDirection.Ascending));

            // Привязка данных к DataGrid
            EmployeesDataGrid.ItemsSource = employeesViewSource.View;

            // Заполнение ComboBox ФИО
            FilterFullNameComboBox.ItemsSource = employeesCollection;
            FilterFullNameComboBox.SelectedIndex = -1; // Сброс выбора
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void ApplyFilterButton_Click(object sender, RoutedEventArgs e)
        {
            // Получение значений фильтров
            string fullNameFilter = FilterFullNameComboBox.SelectedItem as string;
            string positionFilter = FilterPositionComboBox.Text.Trim();
            decimal? salaryFilter = null;
            if (decimal.TryParse(FilterSalaryTextBox.Text.Trim(), out decimal parsedSalary))
            {
                salaryFilter = parsedSalary;
            }

            // Применение фильтров
            var filteredCollection = employeesCollection.Where(emp =>
                (string.IsNullOrEmpty(fullNameFilter) || emp.ФИО == fullNameFilter) &&
                (string.IsNullOrEmpty(positionFilter) || emp.Должность == positionFilter) &&
                (!salaryFilter.HasValue || emp.Зарплата == salaryFilter)
            ).ToList();

            // Обновление представления
            employeesViewSource.Source = filteredCollection;
            EmployeesDataGrid.ItemsSource = employeesViewSource.View;
        }

        private void ResetFilters()
        {
            FilterFullNameComboBox.SelectedIndex = -1;
            FilterPositionComboBox.SelectedIndex = -1;
            FilterSalaryTextBox.Text = string.Empty;
        }

        private void FilterFullNameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ApplyFilterButton_Click(sender, e);
        }
    }

    public class EmployeeViewModel
    {
        public string ФИО { get; set; }
        public DateTime ДатаПриема { get; set; }
        public decimal Зарплата { get; set; }
        public string Должность { get; set; }
        public string Логин { get; set; }
    }
}