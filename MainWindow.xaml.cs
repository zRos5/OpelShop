using System;
using System.Windows;
using System.Windows.Controls;

namespace OpelShop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Contenido.Navigate(new Uri("Inicio.xaml", UriKind.Relative));
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            var boton = (RadioButton)sender;
            Contenido.Navigate(new Uri((string)boton.Tag, UriKind.Relative));
        }
    }
}