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
        private Stock db = new Stock(); // Objet base de données Stock
        public catalogList()
        {
            InitializeComponent();
        }
        private void Catalog_List(object sender, RoutedEventArgs e) // Méthode d'affichage de la liste des produits
        {
            var listing = db.produit.Include(c => c.categorie); // Jointure pour la table produit avec la table categorie
            listing_product.ItemsSource = listing.ToList(); // Source de la liste dans le fichier xaml vaut la jointure ci-dessus
        }

        //Dropdown
        public void GridLoaded(object sender, RoutedEventArgs e)
        {
            categoryDropDown.ItemsSource = db.categorie.ToList();
        }

        //CaseSwitch pour trier par catégorie : 
        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            int SortVar = Convert.ToInt32(categoryDropDown.SelectedValue);
            switch (SortVar)
            {
                case 1:
                    listing_product.ItemsSource = db.produit.Where(tempCar => tempCar.categorie.id == 1).ToList();
                    break;
                case 2:
                    listing_product.ItemsSource = db.produit.Where(TempBike => TempBike.categorie.id == 2).ToList();
                    break;
                case 3:
                    listing_product.ItemsSource = db.produit.Where(TempBike => TempBike.categorie.id == 3).ToList();
                    break;

                default:
                    listing_product.ItemsSource = db.produit.ToList();
                    break;

            }
        }
        // Bouton de suppression du choix de tri, on remet la methode d'affichage de base 
        private void NoSort_Click(object sender, RoutedEventArgs e)
        {
            listing_product.ItemsSource = db.produit.ToList();
        }


    }
}
