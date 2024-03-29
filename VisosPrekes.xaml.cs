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
using System.Windows.Shapes;

namespace antroji_praktika
{
    /// <summary>
    /// Interaction logic for VisosPrekes.xaml
    /// </summary>
    public partial class VisosPrekes : Window
    {
       
        public VisosPrekes(string kategorija)
        {
            InitializeComponent();

            ShowData(kategorija);

        }
        
        public void ShowData(string Category)
        {
            backend.GetAllItemsData duombaze = new backend.GetAllItemsData();
            List<Preke> Daiktai = new List<Preke>();
            Daiktai = duombaze.GetPavadinimas(Category);
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
