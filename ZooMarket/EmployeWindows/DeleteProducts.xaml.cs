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

namespace ZooMarket.EmployeWindows
{
    public partial class DeleteProducts : Window
    {
        ZooMarketEntities1 db = new ZooMarketEntities1();

        public DeleteProducts()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            var products = db.Товары.ToList();
            foreach (var product in products)
            {
                product.Количество = 0; 
            }
            ProductsDataGrid.ItemsSource = products;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Товары product in ProductsDataGrid.ItemsSource)
            {
                if (product.Количество > 0 && product.Количество >= product.Количество)
                {
                    product.Количество -= product.Количество;

                    var списание = new СписаниеТоваров
                    {
                        ТоварID = product.ТоварID,
                        Количество = product.Количество,
                        ДатаСписания = DateTime.Now
                    };
                    db.СписаниеТоваров.Add(списание);
                }
                else if (product.Количество > product.Количество)
                {
                    MessageBox.Show($"Недостаточно товара '{product.Название}' для списания.");
                    return;
                }
            }

            db.SaveChanges();
            MessageBox.Show("Товары успешно списаны.");
            LoadProducts(); 
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Employe employe = new Employe();
            employe.Show();
            this.Close();
        }
    }
}
