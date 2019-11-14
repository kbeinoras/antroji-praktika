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
    /// Interaction logic for VisosNekaterizuotosPrekes.xaml
    /// </summary>
    public partial class VisosNekaterizuotosPrekes : Window
    {
        public VisosNekaterizuotosPrekes()
        {
            InitializeComponent();
            ShowData();
        }
        public void ShowData()
        {
            backend.GetAllItemsWithoutCategory duombaze = new backend.GetAllItemsWithoutCategory();
            List<Preke> Daiktai = new List<Preke>();
            Daiktai = duombaze.GetPavadinimasBeKategorijos();
            for (int i = 0; i < Daiktai.Count; i++)
            {
                StackPanelVisosPrekes.Children.Add(Daiktai[i]);
            }
        }

        private void BtnAtgal_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
