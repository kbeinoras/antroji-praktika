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
    /// Interaction logic for Preke.xaml
    /// </summary>
    public partial class Preke : UserControl
    {
        public Preke()
        {
            InitializeComponent();
        }
        private string Title;
        private string Aprasymas;
        private string Kaina;
        private string euras = "  Eur.";
        private string NuotraukosDir;
        private int ID;
        public void setTitle(string TITLE)
        {
            Title = TITLE;
            LblPavadinimas.Content = Title;
        }
        public void setAprasymas(string APRASYMAS)
        {
            Aprasymas = APRASYMAS;
            LblAprasymas.Content = Aprasymas;
        }
        public void setKaina(string KAINA)
        {
            Kaina = KAINA;
            LblKaina.Content = Kaina+euras;
        }
        public void SetNuotraukosDirekcija(string PHOTOPATH)
        {
            NuotraukosDir = PHOTOPATH;
            Console.WriteLine(NuotraukosDir);
            ImageSource imageSource = new BitmapImage(new Uri(NuotraukosDir));
            this.ImgBoxPreke.Source = imageSource;
            ImgBoxPreke.Stretch = Stretch.Fill;
            Console.WriteLine($"{imageSource}");
        }
        public string GetNuotraukosDirekcija()
        {
            return NuotraukosDir;
        }
        public string GetTitle()
        {
            return Title;
        }
        public string getAprasymas()
        {
            return Aprasymas;
        }
        public string getKaina()
        {
            return Kaina;
        }
        public int GetID()
        {
            return ID;
        }
        public void setID(int ident)
        {
            ID = ident;
        }
        private void BtnKrepselis_Click(object sender, RoutedEventArgs e)
        {
            backend.Cart.InsertToCart(ID, Title, Kaina);

        }
    }
}
