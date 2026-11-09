using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Navigation;

namespace OpelShop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Contenido.Navigated += Contenido_Navigated;
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

        // Animación 1: fundido de entrada al cambiar de pantalla
        private void Contenido_Navigated(object sender, NavigationEventArgs e)
        {
            var fundido = new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(300));
            Contenido.BeginAnimation(UIElement.OpacityProperty, fundido);
        }
    }
}