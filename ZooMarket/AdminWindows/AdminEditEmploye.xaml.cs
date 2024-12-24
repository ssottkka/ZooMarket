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
    
    public partial class AdminEditEmploye : Window
    {
        private ZooMarketEntities1 _context;
        public AdminEditEmploye()
        {
            InitializeComponent();
            _context = new ZooMarketEntities1();
            LoadEmployees();
            LoadPositions();
        }

        private void LoadEmployees()
        {
            var employees = _context.Сотрудники.ToList();
            EmployeeComboBox.ItemsSource = employees;
            EmployeeComboBox.DisplayMemberPath = "ФИО";
            EmployeeComboBox.SelectedValuePath = "СотрудникID";
        }

        private void LoadPositions()
        {
            var positions = _context.Должности.ToList();
            PositionComboBox.ItemsSource = positions;
            PositionComboBox.DisplayMemberPath = "Наименование";
            PositionComboBox.SelectedValuePath = "ДолжностьID";
        }

        private void EmployeeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EmployeeComboBox.SelectedItem is Сотрудники selectedEmployee)
            {
                FullNameTextBox.Text = selectedEmployee.ФИО;
                PositionComboBox.SelectedValue = selectedEmployee.ДолжностьID;
                SalaryTextBox.Text = selectedEmployee.Зарплата.ToString();
                HireDatePicker.SelectedDate = selectedEmployee.ДатаПриема;
                LoginTextBox.Text = selectedEmployee.Логин;
                PasswordBox.Password = selectedEmployee.Пароль;
            }
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void EditEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (EmployeeComboBox.SelectedItem is Сотрудники selectedEmployee)
                {
                    selectedEmployee.ФИО = FullNameTextBox.Text;
                    selectedEmployee.ДолжностьID = (int)PositionComboBox.SelectedValue;
                    selectedEmployee.Зарплата = decimal.Parse(SalaryTextBox.Text);
                    selectedEmployee.ДатаПриема = HireDatePicker.SelectedDate.Value;
                    selectedEmployee.Логин = LoginTextBox.Text;
                    selectedEmployee.Пароль = PasswordBox.Password;

                    _context.SaveChanges();
                    ClearFields();
                    MessageBox.Show("Данные сотрудника успешно изменены!");
                }
                else
                {
                    MessageBox.Show("Выберите сотрудника для редактирования.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при изменении данных сотрудника: {ex.Message}");
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
