﻿using System;
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
    /// Interaction logic for Items.xaml
    /// </summary>
    public partial class Items : UserControl
    {
        public Items()
        {
            InitializeComponent();
        }
        public string Title;
        public void setTitle(string TITLE)
        {
            Title = TITLE;
            LblText.Content = Title;

        }
        public string GetTitle()
        {

            return Title;
        }
        public void SetkategorijaString()
        {
            string kategorijaString = LblText.Content.ToString();
        }

        public string GetkategorijaString()
        {
            return LblText.Content.ToString();
        }
        private void BtnKategorijosPasirinkimas_Click(object sender, RoutedEventArgs e)
        {
            VisosPrekes prekiusarasas = new VisosPrekes();
            prekiusarasas.Show();
        }
    }
}
