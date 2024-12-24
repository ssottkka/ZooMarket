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

namespace ZooMarket
{

    /// <summary>
    /// Логика взаимодействия для AdminAddNewEmploye.xaml
    /// </summary>
    public partial class AdminAddNewEmploye : Window
    {
        private ZooMarketEntities1 _context;
        public AdminAddNewEmploye()
        {
            InitializeComponent();
            _context = new ZooMarketEntities1();
            LoadPositions();
        }

        private void LoadPositions()
        {
            var positions = _context.Должности.ToList();
            PositionComboBox.ItemsSource = positions;
            PositionComboBox.DisplayMemberPath = "Наименование";
            PositionComboBox.SelectedValuePath = "ДолжностьID";
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Проверка на пустые поля
                if (string.IsNullOrWhiteSpace(FullNameTextBox.Text) ||
                    PositionComboBox.SelectedValue == null ||
                    string.IsNullOrWhiteSpace(SalaryTextBox.Text) ||
                    HireDatePicker.SelectedDate == null ||
                    string.IsNullOrWhiteSpace(LoginTextBox.Text) ||
                    string.IsNullOrWhiteSpace(PasswordBox.Password))
                {
                    MessageBox.Show("Заполните все поля !");
                    return;
                }

                var employee = new Сотрудники
                {
                    ФИО = FullNameTextBox.Text,
                    ДолжностьID = (int)PositionComboBox.SelectedValue,
                    Зарплата = decimal.Parse(SalaryTextBox.Text),
                    ДатаПриема = HireDatePicker.SelectedDate.Value,
                    Логин = LoginTextBox.Text,
                    Пароль = PasswordBox.Password
                };

                _context.Сотрудники.Add(employee);
                _context.SaveChanges();

                MessageBox.Show("Сотрудник успешно добавлен!");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении сотрудника: {ex.Message}");
            }
        }

        private void ClearFields()
        {
            FullNameTextBox.Text = "";
            PositionComboBox.SelectedIndex = -1;
            SalaryTextBox.Text = "";
            HireDatePicker.SelectedDate = null;
            LoginTextBox.Text = "";
            PasswordBox.Password = "";
        }
    }
}
