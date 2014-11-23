using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Client.ServerSessionFasadeNamespace;

namespace Client
{
    public partial class MainWindow : Window
    {
        public MyDataContext MyDataContext { get; set; }

        public MainWindow()
        {
            MyDataContext = new MyDataContext();
            InitializeComponent();
            FillData();
        }

        private void FillData()
        {
            var proxy = new SessionFasadeClient();
            var abonentsData = proxy.GetAbonentsData();
            foreach (var abonentData in abonentsData)
                MyDataContext.AbonentsData.Add(abonentData);
        }

        public static void Callback(IAsyncResult result)
        {
            MessageBox.Show("Operacja zwiększania salda abonentów zakończona.");
        }

        private void IncreaseSaldo(object sender, RoutedEventArgs e)
        {
            var proxy = new SessionFasadeClient();
            proxy.BeginIncreaseSaldo(Callback, null);
        }
    }



    public class MyDataContext
    {
        public ObservableCollection<AbonentData> AbonentsData { get; set; }

        public MyDataContext()
        {
            AbonentsData = new ObservableCollection<AbonentData>();
        }
    }
}
