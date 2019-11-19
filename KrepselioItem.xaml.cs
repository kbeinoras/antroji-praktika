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

namespace antroji_praktika
{
    /// <summary>
    /// Interaction logic for KrepselioItem.xaml
    /// </summary>
    public partial class KrepselioItem : UserControl
    {
        public KrepselioItem()
        {
            InitializeComponent();
        }
        private string Title;
        private string Kaina;
        private string euras = "  Eur.";
        private int ID;
        public void setTitle(string TITLE)
        {
            Title = TITLE;
            LblPavadinimas.Content = Title;
        }
        public void setKaina(string KAINA)
        {
            Kaina = KAINA;
            LblKaina.Content = Kaina + euras;
        }
        public string GetTitle()
        {
            return Title;
        }
        public string getKaina()
        {
            return Kaina;
        }
        public void setID(int id)
        {
            ID = id;
        }
        public int getID()
        {
            return ID;
        }

        private void BtnPasalinti_Click(object sender, RoutedEventArgs e)
        {
            
            backend.Cart.DeleteItem(ID, Title, Kaina);
            MessageBox.Show("Prekė buvo sėkmingai pašalinta iš krepšelio, perkraukite puslapį!");
            
        }
    }
}
