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
        // Déclaration des regex
        string regexName = @"^[0-9a-zA-Z\-éêëèâäüûùîïöôÿç]+";
        string regexDescription = @"^[a-zA-Z0-9\-éêëèâäüûùîïöôÿ!.,;!? ]+";
        string regexReference = @"[A-Z0-9]+";
        string regexPrice = @"[1-9]+";
        string regexQuantity = @"[1-9]+";
        //
        private Stock db = new Stock(); // Objet base de données Stock
        //
        public addProduct()
        {
            InitializeComponent();
        }
        private void AddCar(object sender, RoutedEventArgs e) // Méhode ajout du produit
        {
            produit new_car = new produit();
            //
            string testRegex = "";
            //
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
                    // Message d'erreur en cas d'invalidité
                    MessageBox.Show("Veuillez utiliser que des caractères valides pour le champ description.");
                    testRegex = "errorRegex";
                }
            }
            else
            {
                // Message d'erreur en cas de champ non rempli
                MessageBox.Show("Veuillez écrire une description");
                testRegex = "error";
            }

            // Vérification que le champ PRICE n'est pas null ou vide
            if (!String.IsNullOrEmpty(price.Text))
            {
                //Vérification de la validité de l'entrée user
                if (!Regex.IsMatch(price.Text, regexPrice))
                {
                    // Message d'erreur en cas d'invalidité
                    MessageBox.Show("Veuillez écrire un prix valide");
                    testRegex = "errorRegex";
                }
            }
            else
            {
                // Message d'erreur en cas de champ non rempli
                MessageBox.Show("Veuillez indiquer un prix");
                testRegex = "error";
            }

            // Vérification que le champ QUANTITE n'est pas null ou vide
            if (!String.IsNullOrEmpty(quantity.Text))
            {
                //Vérification de la validité de l'entrée user
                if (!Regex.IsMatch(quantity.Text, regexQuantity))
                {
                    // Message d'erreur en cas d'invalidité
                    MessageBox.Show("Ecrire une quantité valide");
                    testRegex = "errorRegex";
                }
            }
            else
            {
                // Message d'erreur en cas de champ non rempli
                MessageBox.Show("Veuillez indiquer une quantité");
                testRegex = "error";
            }

            // Vérification qu'une catégorie à bien été sélectionné
            if (categorie_choice.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez indiquer une catégorie");
            }
            // Si testRegex ne comporte pas d'erreurs
            if (string.IsNullOrEmpty(testRegex))
            {
                //
                new_car.nom = name.Text; // Ajout du nom de la voiture
                new_car.reference = reference.Text; // Ajout de la référence
                new_car.description = description.Text; // Ajout de la descritpion
                new_car.prix = Convert.ToInt32(price.Text); // Ajout du prix indiqué
                new_car.quantite = Convert.ToInt32(quantity.Text); // Ajout de la quantité
                new_car.image = image.Text; // Ajout de l'adresse du répertoire de l'image corespondante
                //
                new_car.id_categorie = Convert.ToInt32(categorie_choice.SelectedValue); // Récupère l'id de la catégorie
                //
                db.produit.Add(new_car); // Ajout du produit
                db.SaveChanges(); // Sauvergarde
                //
                MessageBox.Show("Le produit a bien été ajouté"); // Affichage du message de confirmation d'ajout
                //
                name.Clear(); // Vidage du champs nom
                reference.Clear(); // Vidage du champs reference
                description.Clear(); // Vidage du champs description
                price.Clear(); // Vidage du champs price
                quantity.Clear(); // Vidage du champs quantity
                image.Clear(); // Vidage du champs image
                //
                categorie_choice.SelectedIndex = -1; // Réinitialisation de la valeur sélectionée pour la catégorie
            }
        }
        private void Combo(object sender, RoutedEventArgs e) // Méthode pour affichage des combobox
        {
            categorie_choice.ItemsSource = db.categorie.ToList();
        }
        private void Return(object sender, RoutedEventArgs e) // Méthode pour retourner à l'accueil
        {
            this.NavigationService.Navigate(new System.Uri("stockManagment.xaml", UriKind.RelativeOrAbsolute));
        }
        private void BrowseButton_Click(object sender, RoutedEventArgs e) // Méhode pour parcourir le chemin où se situe l'image
        {
            // Création du système "OpenFileDialog" pour parcourir
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
            // Filtrer les extensions 
            openFileDlg.DefaultExt = ".jpg"; // Extension de fichier par défaut
            openFileDlg.Filter = "JPEG  (.jpg)|*.jpg"; // Autres extensions possibles
            // Lancer OpenFileDialog en appelant la méthode ShowDialog
            Nullable<bool> result = openFileDlg.ShowDialog();
            // Get the selected file name and display in a TextBox.
            // Load content of file in a TextBlock
            if (result == true)
            {
                image.Text = openFileDlg.FileName;
            }
        }
    }
}