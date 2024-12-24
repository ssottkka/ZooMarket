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
using ZooMarket.DirectorWindows;

namespace ZooMarket
{
    /// <summary>
    /// Логика взаимодействия для Director.xaml
    /// </summary>
    public partial class Director : Window
    {
        public Director()
        {
            InitializeComponent();
        }

        private void ProductsButton_Click(object sender, RoutedEventArgs e)
        {
            CheckCatalog checkCatalog = new CheckCatalog();
            checkCatalog.Show();
            this.Close();
        }

        private void RepotrCheckkButton_Click(object sender, RoutedEventArgs e)
        {
            SalesReport salesReport = new SalesReport();
            salesReport.Show();
            this.Close();
        }

        private void BuyRequestButton_Click(object sender, RoutedEventArgs e)
        {
            AddBuyRequest addBuyRequest = new AddBuyRequest();
            addBuyRequest.Show();
            this.Close();
        }

        private void EditEmployesButton_Click(object sender, RoutedEventArgs e)
        {
            EditEmployes editEmployes = new EditEmployes();
            editEmployes.Show();
            this.Close();
        }

        private void AddNewEmployes_Click(object sender, RoutedEventArgs e)
        {
            AddEmploye addEmploye = new AddEmploye();   
            addEmploye.Show();  
            this.Close ();  
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(); 
            main.Show();
            this.Close();
        }
    }
}
