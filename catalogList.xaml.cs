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
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Text.RegularExpressions;

namespace Gestion
{
    /// <summary>
    /// Logique d'interaction pour catalogList.xaml
    /// </summary>
    public partial class catalogList : Page
    {
        private Stock db = new Stock();
        public catalogList()
        {
        InitializeComponent();
        }
        private void Catalog_List(object sender, RoutedEventArgs e)
        {
        var listing = db.produit.Include(c => c.categorie);
        listing_product.ItemsSource = listing.ToList();
        }
    }
}
