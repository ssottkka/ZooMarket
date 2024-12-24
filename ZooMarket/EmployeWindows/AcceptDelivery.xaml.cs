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
    public partial class AcceptDelivery : Window
    {
        private ZooMarketEntities1 db;
        private СоставЗаявки selectedRequest;

        public AcceptDelivery()
        {
            InitializeComponent();
            db = new ZooMarketEntities1();
            LoadRequests();
        }

        private void LoadRequests()
        {
            var requests = db.ЗаявкиНаПокупку
                .Where(r => r.Статус == 2)
                .Join(db.СоставЗаявки, r => r.ЗаявкаID, c => c.ЗаявкиID, (r, c) => new { r, c })
                .Join(db.Товары, rc => rc.c.ТоварID, t => t.ТоварID, (rc, t) => new { rc, t })
                .Join(db.СтатусыЗаявки, rct => rct.rc.r.Статус, s => s.СтатусID, (rct, s) => new
                {
                    ЗаявкаID = rct.rc.r.ЗаявкаID,
                    НазваниеТовара = rct.t.Название,
                    Количество = rct.rc.c.Количество,
                    НаименованиеСтатуса = s.Наименование
                })
                .ToList();

            RequestsDataGrid.ItemsSource = requests;
        }

        private void RequestsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = RequestsDataGrid.SelectedItem as dynamic;
            if (selectedItem != null)
            {
                int selectedRequestId = selectedItem.ЗаявкаID;
                selectedRequest = db.СоставЗаявки.FirstOrDefault(c => c.ЗаявкиID == selectedRequestId);
                AcceptButton.IsEnabled = selectedRequest != null;
            }
            else
            {
                selectedRequest = null;
                AcceptButton.IsEnabled = false;
            }
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedRequest != null)
            {
                var товар = db.Товары.FirstOrDefault(t => t.ТоварID == selectedRequest.ТоварID);
                if (товар != null)
                {
                    товар.Количество += selectedRequest.Количество;
                    var поставка = new Поставки
                    {
                        ПоставщикID = 1, 
                        ДатаПоставки = DateTime.Now
                    };
                    db.Поставки.Add(поставка);
                    var заявка = db.ЗаявкиНаПокупку.FirstOrDefault(r => r.ЗаявкаID == selectedRequest.ЗаявкиID);
                    if (заявка != null)
                    {
                        заявка.Статус = 3;
                    }
                    db.SaveChanges();

                    MessageBox.Show("Поставка успешно принята.");
                    LoadRequests();
                }
                else
                {
                    MessageBox.Show("Товар не найден.");
                }
            }
            else
            {
                MessageBox.Show("Выберите заявку для принятия поставки.");
            }
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void HistoryButton_Click(object sender, RoutedEventArgs e)
        {
            DeliveryHistory deliveryHistory = new DeliveryHistory();
            deliveryHistory.Show();
            this.Close();
        }
    }
}
