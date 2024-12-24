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
    public partial class Employe : Window
    {
        public Employe()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void CatalogCheckButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeCatalogCheck employeCatalogCheck = new EmployeCatalogCheck();
            employeCatalogCheck.Show();
            this.Close();
        }

        private void SaleButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeSaleProduct employeSaleProduct = new EmployeSaleProduct();
            employeSaleProduct.Show();
            this.Close();
        }

        private void SaleReportButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeSaleReport employeSaleReport = new EmployeSaleReport();
            employeSaleReport.Show();
            this.Close();
        }

        private void AcceptDeliveryButton_Click(object sender, RoutedEventArgs e)
        {
            AcceptDelivery acceptDelivery = new AcceptDelivery();
            acceptDelivery.Show();
            this.Close();
        }

        private void DeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            DeleteProducts deleteProducts = new DeleteProducts();
            deleteProducts.Show();
            this.Close();
                
        }
    }
}