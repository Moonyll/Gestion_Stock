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

namespace Gestion
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        private void Catalog(object sender, RoutedEventArgs e)
        {
            Main.Content = new catalogList();
        }
        private void Managment(object sender, RoutedEventArgs e)
        {
            Main.Content = new stockManagment();
        }
        private void Home(object sender, RoutedEventArgs e)
        {
            Main.Content = new Accueil();
        }
        private void AddP(object sender, RoutedEventArgs e)
        {
            Main.Content = new addProduct();
        }
        private void Window_Start(object sender, RoutedEventArgs e)
        {
            Main.Navigate(new System.Uri("Accueil.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
