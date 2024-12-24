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
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace ZooMarket
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int attempts = 0;
        ZooMarketEntities1 db = new ZooMarketEntities1();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var login = LoginTextBox.Text;
            var password = PasswordBox.Password;
            var ipAddress = GetIPAddress(); // Метод для получения IP-адреса
            var status = "Неуспешный вход"; // По умолчанию статус неуспешный
            var employee = db.Сотрудники.FirstOrDefault(x => x.Логин == login && x.Пароль == password && x.ДолжностьID == 1);
            if (employee != null)
            {
                Application.Current.Properties["CurrentEmployeeId"] = employee.СотрудникID; // Сохраняем ID сотрудника
                status = "Успешный вход";
                EmployeWindows.Employe employeWindow = new EmployeWindows.Employe();
                employeWindow.Show();
                this.Close();
                return;
            }
            var director = db.Сотрудники.FirstOrDefault(x => x.Логин == login && x.Пароль == password && x.ДолжностьID == 2);
            if (director != null)
            {
                status = "Успешный вход";
                Director directorWindow = new Director();
                directorWindow.Show();
                this.Close();
            }
            var admin = db.Сотрудники.FirstOrDefault(x => x.Логин == login && x.Пароль == password && x.ДолжностьID == 3);
            if (admin != null)
            {
                status = "Успешный вход";
                Admin adminWindow = new Admin();
                adminWindow.Show();
                this.Close();
            }
            if (employee == null && director == null && admin == null)
            {
                ErrorMessageTextBlock.Text = "Неверный логин или пароль";
                attempts++;
            }
            if (attempts >= 10)
            {
                MessageBox.Show("Вы превысили количество попыток входа");
                this.Close();
            }
            // Добавление записи в таблицу ИсторияВходов
            AddLoginAttempt(login, password, ipAddress, status);
        }
        private void AddLoginAttempt(string login, string password, string ipAddress, string status)
        {
            var employee = db.Сотрудники.FirstOrDefault(x => x.Логин == login && x.Пароль == password);
            int? employeeId = employee?.СотрудникID;

            // Получение СтатусID из таблицы СтатусВхода
            var statusEntry = db.СтатусВхода.FirstOrDefault(x => x.Наименование == status);
            int statusId = statusEntry?.СтатусID ?? 0; // Если статус не найден, используем 0

            var loginAttempt = new ИсторияВходов
            {
                СотрудникID = employeeId,
                ДатаВхода = DateTime.Now,
                IPадрес = ipAddress,
                Статус = statusId,
                Логин = login,
                Пароль = password
            };

            db.ИсторияВходов.Add(loginAttempt);
            db.SaveChanges();
        }
        private string GetIPAddress()
        {
            return "192.168.1.1";
        }
    }
}