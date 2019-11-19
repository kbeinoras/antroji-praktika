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
    /// Interaction logic for Krepselis.xaml
    /// </summary>
    public partial class Krepselis : Window
    {
        public Krepselis()
        {
            InitializeComponent();
            ShowData();
            ShowSuma();
        }
        public void ShowData()
        {
            List<KrepselioItem> krepselis = new List<KrepselioItem>();
            List<backend.Item> listas = new List<backend.Item>();
            listas = backend.Cart.GetItems();
            int count = backend.Cart.GetCount();
            for (int i = 0; i < count; i++)
            {
                krepselis.Add(new KrepselioItem());
                krepselis[i].setTitle(listas[i].GetPavadinimas());
                krepselis[i].setKaina(listas[i].GetKaina());
                krepselis[i].setID(listas[i].GetID());
                StackPanelKrepselis.Children.Add(krepselis[i]);
            }
        }

        private void BtnAtgal_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        public void TxtIsVisoKaina_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
        public void ShowSuma()
        {
            int suma = backend.Cart.GetSuma();
            string strngSuma = Convert.ToString(suma);
            TxtIsVisoKaina.Text = strngSuma;
        }

        private void BtnFormCheck_Click(object sender, RoutedEventArgs e)
        {

            backend.Cart.FormCheck();
            backend.Cart.ClearItems();
            MessageBox.Show("Čekis buvo suformuotas");
            
        }
    }
}
