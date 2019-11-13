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
        public void setTitle(string TITLE)
        {
            Title = TITLE;
            TxtPavadinimas.Text = Title;
        }
        public void setAprasymas(string APRASYMAS)
        {
            Aprasymas = APRASYMAS;
            TxtAprasymas.Text = Aprasymas;
        }
        public void setKaina(string KAINA)
        {
            Kaina = KAINA;
            TxtAprasymas.Text = Kaina;
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
    }
}