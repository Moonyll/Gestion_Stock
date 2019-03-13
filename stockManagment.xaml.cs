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
        
        // Déclaration des regex
        string regexName = @"^[0-9a-zA-Z\-éêëèâäüûùîïöôÿç]+";
        string regexDescription = @"^[a-zA-Z0-9\-éêëèâäüûùîïöôÿ!.,;!? ]+";
        string regexReference = @"[A-Z0-9]+";
        string regexPrice = @"[1-9]+";
        string regexQuantity = @"[1-9]+";
        //

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

            name.Text = car.nom;
            reference.Text = car.reference;
            description.Text = car.description;
            price.Text = car.prix.ToString();
            quantity.Text = car.quantite.ToString();
            categorie_choice.Text = car.categorie.categorie1;
            //
        }
        private void UpCar(object sender, RoutedEventArgs e)
        {
            string testRegex = "";

            //Vérification que le champ NOM n'est pas null ou vide
            if (!String.IsNullOrEmpty(name.Text))
            {
                //Vérification de la validité de l'entrée user
                if (!Regex.IsMatch(name.Text, regexName))
                {
                    //Message d'erreur en cas d'invalidité
                    MessageBox.Show("Ecrire un nom valide");
                    testRegex = "errorRegex";
                }
            }
            else
            {
                //Message d'erreur en cas de champ non rempli
                MessageBox.Show("Veuillez écrire un nom");
                testRegex = "error";
            }

            //Vérification que le champ REFERENCE n'est pas null ou vide
            if (!String.IsNullOrEmpty(reference.Text))
            {
                //Vérification de la validité de l'entrée user
                if (!Regex.IsMatch(reference.Text, regexReference))
                {
                    //Message d'erreur en cas d'invalidité
                    MessageBox.Show("Ecrire une référence produit valide");
                    testRegex = "errorRegex";
                }
            }
            else
            {
                //Message d'erreur en cas de champ non rempli
                MessageBox.Show("Veuillez écrire référence produit");
                testRegex = "error";
            }

            //Vérification que le champ DESCRPTION n'est pas null ou vide
            if (!String.IsNullOrEmpty(description.Text))
            {
                //Vérification de la validité de l'entrée user
                if (!Regex.IsMatch(description.Text, regexDescription))
                {
                    //Message d'erreur en cas d'invalidité
                    MessageBox.Show("Veuillez utiliser que des caractères valides pour le champ description.");
                    testRegex = "errorRegex";
                }
            }
            else
            {
                //Message d'erreur en cas de champ non rempli
                MessageBox.Show("Veuillez écrire une description");
                testRegex = "error";
            }

            //Vérification que le champ PRIX n'est pas null ou vide
            if (!String.IsNullOrEmpty(price.Text))
            {
                //Vérification de la validité de l'entrée user
                if (!Regex.IsMatch(price.Text, regexPrice))
                {
                    //Message d'erreur en cas d'invalidité
                    MessageBox.Show("Veuillez écrire un prix valide");
                    testRegex = "errorRegex";
                }
            }
            else
            {
                //Message d'erreur en cas de champ non rempli
                MessageBox.Show("Veuillez indiquer un prix");
                testRegex = "error";
            }

            //Vérification que le champ QUANTITE n'est pas null ou vide
            if (!String.IsNullOrEmpty(quantity.Text))
            {
                //Vérification de la validité de l'entrée user
                if (!Regex.IsMatch(quantity.Text, regexQuantity))
                {
                    //Message d'erreur en cas d'invalidité
                    MessageBox.Show("Ecrire une quantité valide");
                    testRegex = "errorRegex";
                }
            }
            else
            {
                //Message d'erreur en cas de champ non rempli
                MessageBox.Show("Veuillez indiquer une quantité");
                testRegex = "error";
            }

            //Vérification qu'une catégorie à bien été sélectionné
            if (categorie_choice.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez indiquer une catégorie");
            }


            //Si testRegex ne comporte pas d'erreurs
            if (string.IsNullOrEmpty(testRegex))
            {

                car.nom = name.Text;
                car.reference = reference.Text;
                car.description = description.Text;
                car.prix = Convert.ToInt32(price.Text);
                car.quantite = Convert.ToInt32(quantity.Text);
                //new_car.image = image.Text;

                car.id_categorie = Convert.ToInt32(categorie_choice.SelectedValue);

                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show("Le produit a bien été mis à jour");

                name.Clear();
                reference.Clear();
                description.Clear();
                price.Clear();
                quantity.Clear();
                //image.Clear();


                categorie_choice.SelectedIndex = -1;
                stock_product.Items.Refresh();
            }
        }
        /////////////////////////////////
        //car.nom = nom.Text;
        //    car.reference=reference.Text;
        //    car.description= description.Text;
        //    car.prix = Convert.ToInt32(prix.Text);
        //    car.quantite = Convert.ToInt32(quantite.Text);
        //    //
        //    car.id_categorie = Convert.ToInt32(categorie_choice.SelectedValue);
        //    //
        //    db.Entry(car).State = EntityState.Modified;
        //    db.SaveChanges();
        //    //
        //    MessageBox.Show("Le produit a bien été mis à jour");
        //    //
        //    stock_product.Items.Refresh();
        //}
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
        private void Combo(object sender, RoutedEventArgs e)
        {
            categorie_choice.ItemsSource = db.categorie.ToList();
        }
    }
}