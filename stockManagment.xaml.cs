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
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Text.RegularExpressions;

namespace Gestion
{
    /// <summary>
    /// Logique d'interaction pour stockManagment.xaml
    /// </summary>
    public partial class stockManagment : Page
    {
        private Stock db = new Stock();
        public stockManagment()
        {
        InitializeComponent();
        }
        private void Stock_List(object sender, RoutedEventArgs e)
        {
        var listing = db.produit.Include(s => s.categorie);
        stock_product.ItemsSource = listing.ToList();
        }
    }
}
