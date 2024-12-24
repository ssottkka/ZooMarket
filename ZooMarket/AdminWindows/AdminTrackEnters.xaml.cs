using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace ZooMarket
{
    public partial class AdminTrackEnters : Window
    {
        private ObservableCollection<LoginHistoryViewModel> historyCollection;
        private CollectionViewSource historyViewSource;
        private ZooMarketEntities1 db;

        public AdminTrackEnters()
        {
            InitializeComponent();
            db = new ZooMarketEntities1();
            LoadLoginHistory();
            ResetFilters();
        }

        private void LoadLoginHistory()
        {
            
            var statuses = db.СтатусВхода.Select(s => s.Наименование).Distinct().ToList();
            FilterStatusComboBox.ItemsSource = statuses;
            FilterStatusComboBox.SelectedIndex = -1; 

            
            var employees = db.Сотрудники.Select(e => new
            {
                ФИО = e.ФИО,
                СотрудникID = e.СотрудникID
            }).ToList();
            FilterFullNameComboBox.ItemsSource = employees;
            FilterFullNameComboBox.DisplayMemberPath = "ФИО";
            FilterFullNameComboBox.SelectedValuePath = "СотрудникID";
            FilterFullNameComboBox.SelectedIndex = -1; 

            var historyData = db.ИсторияВходов
                .Include(lh => lh.Сотрудники)
                .Include(lh => lh.СтатусВхода)
                .ToList()
                .Select(lh => new LoginHistoryViewModel
                {
                    ФИО = lh.Сотрудники?.ФИО ?? "Неизвестный пользователь",
                    ДатаВхода = (DateTime)lh.ДатаВхода,
                    IPадрес = lh.IPадрес,
                    Статус = lh.СтатусВхода?.Наименование ?? "Неизвестный статус",
                    Логин = lh.Логин,
                    Пароль = lh.Пароль
                })
                .ToList();

            
            historyCollection = new ObservableCollection<LoginHistoryViewModel>(historyData);

            historyViewSource = new CollectionViewSource { Source = historyCollection };
            historyViewSource.SortDescriptions.Add(new SortDescription("ДатаВхода", ListSortDirection.Ascending));

            LoginHistoryDataGrid.ItemsSource = historyViewSource.View;
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void ApplyFilterButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedEmployee = FilterFullNameComboBox.SelectedItem as dynamic; 
            string fullNameFilter = selectedEmployee?.ФИО; 
            string ipAddressFilter = FilterIPAddressTextBox.Text.Trim().ToLower();
            string statusFilter = FilterStatusComboBox.Text.Trim();

            var filteredCollection = historyCollection.Where(entry =>
                (string.IsNullOrEmpty(fullNameFilter) || entry.ФИО == fullNameFilter) &&
                (string.IsNullOrEmpty(ipAddressFilter) || entry.IPадрес.ToLower().Contains(ipAddressFilter)) &&
                (string.IsNullOrEmpty(statusFilter) || entry.Статус == statusFilter)
            ).ToList();

            historyViewSource.Source = filteredCollection;
            LoginHistoryDataGrid.ItemsSource = historyViewSource.View;
        }

        private void FilterFullNameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ApplyFilterButton_Click(sender, e);
        }

        private void ResetFilters()
        {
            FilterFullNameComboBox.SelectedIndex = -1;
            FilterIPAddressTextBox.Text = string.Empty;
            FilterStatusComboBox.SelectedIndex = -1;
        }

       
    }

    public class LoginHistoryViewModel
    {
        public string ФИО { get; set; }
        public DateTime ДатаВхода { get; set; }
        public string IPадрес { get; set; }
        public string Статус { get; set; }
        public string Логин { get; set; }
        public string Пароль { get; set; }
    }
}