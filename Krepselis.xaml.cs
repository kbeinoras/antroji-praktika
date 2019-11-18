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
    }
}
