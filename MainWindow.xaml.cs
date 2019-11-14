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
using System.Data.SQLite;

namespace antroji_praktika
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ShowData();
        }
     
        public void ShowData()
        {
            backend.GetData duombaze = new backend.GetData();
            List<Items> Daiktai = new List<Items>();
            Daiktai = duombaze.GetKategorijos();
            for(int i=0; i<Daiktai.Count; i++)
            {
                StackPanel1.Children.Add(Daiktai[i]);
            }
        }

       private void BtnVisosPrekes_Click(object sender, RoutedEventArgs e)
        {
            VisosPrekes prekiusarasas = new VisosPrekes(Title);
            prekiusarasas.Show();
        }
        public void GetCategoryName(string name)
        {
            MessageBox.Show(name);
        }

        private void BtnVisosPrekes_Click_1(object sender, RoutedEventArgs e)
        {
            VisosNekaterizuotosPrekes prekes = new VisosNekaterizuotosPrekes();
            prekes.Show();
        }
    }
}
