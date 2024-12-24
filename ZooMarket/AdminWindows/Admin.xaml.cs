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
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            AdminAddNewEmploye adminAddNewEmploye = new AdminAddNewEmploye();
            adminAddNewEmploye.Show();
            this.Close();
        }


        private void TrackLoginsButton_Click(object sender, RoutedEventArgs e)
        {
            AdminTrackEnters adminTrackEnters = new AdminTrackEnters();
            adminTrackEnters.Show();
            this.Close();
        }


        private void ViewUsersButton_Click(object sender, RoutedEventArgs e)
        {
            AdminCheckUsers adminCheckUsers = new AdminCheckUsers();
            adminCheckUsers.Show();
            this.Close();
        }


        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void EditEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            AdminEditEmploye adminEditEmploye = new AdminEditEmploye();
            adminEditEmploye.Show();
            this.Close();
        }

        private void DeleteEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            AdminDeleteEmploye adminDeleteEmploye = new AdminDeleteEmploye();
            adminDeleteEmploye.Show();
            this.Close();
        }
    }
}
