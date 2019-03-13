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
        int idtodel; // id pour la suppression d'un produit
        public stockManagment()
        {
            InitializeComponent();
        }
        private void Stock_List(object sender, RoutedEventArgs e)
        {
            var listing = db.produit.Include(s => s.categorie); // Jointure pour la table produit avec la table categorie
            stock_product.ItemsSource = listing.ToList(); // Source de la liste dans le fichier xaml vaut la jointure ci-dessus
        }
        private void Car_Details(object sender, MouseButtonEventArgs e) // Méthode pour afficher le détail du produit dans le formulaire
        {
            if (stock_product.SelectedItem == null) return; // Si aucun produit sélectionné retourner la méthode
            //
            car = stock_product.SelectedItem as produit; // Instanciation car en tant que produit
                                                         //
            idtodel = car.id; // Si on veut supprimer ce produit
                              //
            name.Text = car.nom; // Nom du produit qui s'affiche dans le champs name
            reference.Text = car.reference; // Référence du produit qui s'affiche dans le champs référence
            description.Text = car.description; // Description du produit qui s'affiche dans le champs description
            price.Text = car.prix.ToString(); // Prix du produit qui s'affiche dans le champs price
            quantity.Text = car.quantite.ToString(); // Quantité du produit qui s'affiche dans le champ quantity
            categorie_choice.Text = car.categorie.categorie1; // Catégorie du produit qui s'affiche dans le champs categorie
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
                //
                car.nom = name.Text; // Nom modifié
                car.reference = reference.Text; // Référence modifiée
                car.description = description.Text; // Déscription modifiée
                car.prix = Convert.ToInt32(price.Text); // Prix modifié
                car.quantite = Convert.ToInt32(quantity.Text); // Quantité modifiée
                //
                car.id_categorie = Convert.ToInt32(categorie_choice.SelectedValue); // Nouvel id de la catégorie modifiée
                //
                db.Entry(car).State = EntityState.Modified; // Modifications prises en compte dans la base de données
                db.SaveChanges(); // Sauvegarde des modifications
                //
                MessageBox.Show("Le produit a bien été mis à jour");
                //
                name.Clear(); // Vidage du champs nom
                reference.Clear(); // Vidage du champs reference
                description.Clear(); // Vidage du champs description
                price.Clear(); // Vidage du champs price
                quantity.Clear(); // Vidage du champs quantity
                //image.Clear();
                //
                categorie_choice.SelectedIndex = -1; // Réinitialisation de la valeur sélectionée pour la catégorie
                stock_product.Items.Refresh(); // Rafraîchissement de la liste
            }
        }
        private void DelCar(object sender, RoutedEventArgs e)
        {
            produit car = db.produit.Find(idtodel); // Trouve l'équivalent de l'id du produit a supprimer
            db.produit.Remove(car); // Suppression du produit
            db.SaveChanges(); // Sauvegarde de la modification de la base de données
            //
            MessageBox.Show("Le produit a bien été supprimé");
            // Updating List
            stock_product.ItemsSource = null; // Vidage temporaire de la liste
            stock_product.ItemsSource = db.produit.ToList();  // Rafraîchissement de la liste
        }
        private void Combo(object sender, RoutedEventArgs e) // Méthode d'affichage de la liste des produits
        {
            categorie_choice.ItemsSource = db.categorie.ToList();
        }
    }
}