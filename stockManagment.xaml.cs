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
    /// Logique d'interaction pour stockManagment.xaml
    /// </summary>
    public partial class stockManagment : Page
    {
        private Stock db = new Stock();
        produit car;
        
        int idtodel;
        public stockManagment()
        {
            InitializeComponent();
        }
        private void Stock_List(object sender, RoutedEventArgs e)
        {
            var listing = db.produit.Include(s => s.categorie);
            stock_product.ItemsSource = listing.ToList();
            //
            //List<produit> produits = db.produit.ToList();
            //foreach (produit product in produits)
            //{
            //stock_product.Items.Add(product);

            //product.image = $"img/{product.image}.jpg";
            //}
        }
        private void Car_Details(object sender, MouseButtonEventArgs e)
        {
            if (stock_product.SelectedItem == null) return;
            
            car = stock_product.SelectedItem as produit;
           

            idtodel = car.id; // Si on veut supprimer ce produit

            nom.Text = car.nom;
            reference.Text = car.reference;
            description.Text = car.description;
            prix.Text = car.prix.ToString();
            quantite.Text = car.quantite.ToString();
            categorie.Text = car.categorie.categorie1;
            //
        }
        private void UpCar(object sender, RoutedEventArgs e)
        {

            car.nom = nom.Text;
            car.reference=reference.Text;
            car.description= description.Text;
            car.prix = Convert.ToInt32(prix.Text);
            car.quantite = Convert.ToInt32(quantite.Text);
            //categorie.categorie = categorie.Text;
            //
            db.Entry(car).State = EntityState.Modified;
            db.SaveChanges();
            //
            MessageBox.Show("Le produit a bien été mis à jour");
            //
            stock_product.Items.Refresh();
        }
        private void DelCar(object sender, RoutedEventArgs e)
        {
            produit car = db.produit.Find(idtodel);
            db.produit.Remove(car);
            db.SaveChanges();
            //
            MessageBox.Show("Le produit a bien été supprimé");
            // Updating List
            stock_product.ItemsSource = null;
            stock_product.ItemsSource = db.produit.ToList();  //
        }
    }
}