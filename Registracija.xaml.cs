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
    /// Interaction logic for Registracija.xaml
    /// </summary>
    public partial class Registracija : Window
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void BtnAtgal_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow PagLangas = new MainWindow();
            PagLangas.Show();
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            
            string name = TxtSlapyvardis.Text;
            string pass = PassBox.Password;
            if (name != "" && pass!="")
            {
                backend.GetRegistration.Registracija(name, pass);
                MessageBox.Show("ura");
            }
            else
            {
                MessageBox.Show("Visi laukeliai turi buti uzpildyti");
            }
        }
    }
}
