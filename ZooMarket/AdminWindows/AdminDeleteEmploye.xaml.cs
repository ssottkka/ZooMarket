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
    /// Логика взаимодействия для AdminDeleteEmploye.xaml
    /// </summary>
    public partial class AdminDeleteEmploye : Window
    {
        private ZooMarketEntities1 _context;

        public AdminDeleteEmploye()
        {
            InitializeComponent();
            _context = new ZooMarketEntities1();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            var employees = _context.Сотрудники.ToList();
            EmployeeComboBox.ItemsSource = employees;
            EmployeeComboBox.DisplayMemberPath = "ФИО";
            EmployeeComboBox.SelectedValuePath = "СотрудникID";
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

       

        private void DeleteEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (EmployeeComboBox.SelectedItem is Сотрудники selectedEmployee)
                {
                    var dismissal = new Увольнения
                    {
                        СотрудникID = selectedEmployee.СотрудникID,
                        ДатаУвольнения = DismissalDatePicker.SelectedDate.Value,
                        Причина = ReasonTextBox.Text
                    };

                    _context.Увольнения.Add(dismissal);

                    _context.Сотрудники.Remove(selectedEmployee);

                    _context.SaveChanges();

                    MessageBox.Show("Сотрудник успешно уволен!");
                    ClearFields();
                    LoadEmployees(); 
                }
                else
                {
                    MessageBox.Show("Выберите сотрудника для увольнения.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при увольнении сотрудника: {ex.Message}");
            }
        }

        private void ClearFields()
        {
            EmployeeComboBox.SelectedIndex = -1;
            ReasonTextBox.Text = "";
            DismissalDatePicker.SelectedDate = null;
        }

        private void EmployeeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
