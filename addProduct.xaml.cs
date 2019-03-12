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
    /// Logique d'interaction pour addProduct.xaml
    /// </summary>
    public partial class addProduct : Page
    {
        private Stock db = new Stock();
        //produit new_car;

        public addProduct()
        {
        InitializeComponent();
        }
        private void AddCar(object sender, RoutedEventArgs e)
        {
        produit new_car = new produit();
        //
        new_car.nom = nom.Text;
        new_car.reference = reference.Text;
        new_car.description = description.Text;
        new_car.prix = Convert.ToInt32(prix.Text);
        new_car.quantite = Convert.ToInt32(quantite.Text);
        new_car.image = image.Text;
        //
        new_car.id_categorie = Convert.ToInt32(categorie_choice.SelectedValue);
        //categorie.categorie = categorie.Text;
        //
        db.produit.Add(new_car);
        db.SaveChanges();
        //
        MessageBox.Show("Le produit a bien été ajouté");
        //
        }
        private void Combo(object sender, RoutedEventArgs e)
        {
        categorie_choice.ItemsSource = db.categorie.ToList();
        }
        private void Return(object sender, RoutedEventArgs e)
        {
        this.NavigationService.Navigate(new System.Uri("stockManagment.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
