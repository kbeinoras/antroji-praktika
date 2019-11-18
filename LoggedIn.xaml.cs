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

namespace antroji_praktika
{
    /// <summary>
    /// Interaction logic for LoggedIn.xaml
    /// </summary>
    public partial class LoggedIn : Window
    {
        public LoggedIn()
        {
            InitializeComponent();
            ShowData();
        }
        public void ShowData()
        {
            backend.GetData duombaze = new backend.GetData();
            List<Items> Daiktai = new List<Items>();
            Daiktai = duombaze.GetKategorijos();
            for (int i = 0; i < Daiktai.Count; i++)
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

        private void BtnKrepselis_Click(object sender, RoutedEventArgs e)
        {
            Krepselis cart = new Krepselis();
            cart.Show();
        }

        private void BtnAtsijungti_Click(object sender, RoutedEventArgs e)
        {
            MainWindow langas = new MainWindow();
            langas.Show();
            this.Close();
            
        }
    }
}
