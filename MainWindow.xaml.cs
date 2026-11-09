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

        // Permite cambiar de página desde otras pantallas y marcar el menú
        public void IrA(string pagina)
        {
            Contenido.Navigate(new Uri(pagina, UriKind.Relative));
            foreach (var rb in new[] { btnInicio, btnProductos, btnAcceso })
            {
                rb.IsChecked = (string)rb.Tag == pagina;
            }
        }
    }
}