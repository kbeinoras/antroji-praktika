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
            backend.GetKrepselis duombaze = new backend.GetKrepselis();
            List<KrepselioItem> Daiktai = new List<KrepselioItem>();
            Daiktai = duombaze.GetCart();
            for (int i = 0; i < Daiktai.Count; i++)
            {
                StackPanelKrepselis.Children.Add(Daiktai[i]);
            }
        }
    }
}
