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

            // La pantalla de registro cuenta como parte de "Acceso"
            string seccion = pagina == "Registro.xaml" ? "Login.xaml" : pagina;

            foreach (var rb in new[] { btnInicio, btnProductos, btnAcceso })
            {
                rb.IsChecked = (string)rb.Tag == seccion;
            }
        }

        // Muestra u oculta el saludo y el botón de cerrar sesión
        public void ActualizarSesion()
        {
            bool hay = Usuarios.HaySesion;
            btnAcceso.Visibility = hay ? Visibility.Collapsed : Visibility.Visible;
            panelSesion.Visibility = hay ? Visibility.Visible : Visibility.Collapsed;
            txtUsuarioActual.Text = "Hola, " + Usuarios.UsuarioActual;
        }

        private void CerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            Usuarios.CerrarSesion();
            ActualizarSesion();
            IrA("Inicio.xaml");
        }

        // Fundido de entrada al cambiar de pantalla
        private void Contenido_Navigated(object sender, NavigationEventArgs e)
        {
            var fundido = new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(300));
            Contenido.BeginAnimation(UIElement.OpacityProperty, fundido);
        }
    }
}