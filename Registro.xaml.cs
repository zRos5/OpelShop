using System.Windows;
using System.Windows.Controls;

namespace OpelShop
{
    public partial class Registro : Page
    {
        public Registro()
        {
            InitializeComponent();
            Loaded += (s, e) => txtUsuario.Focus();
        }

        private void Crear_Click(object sender, RoutedEventArgs e)
        {
            panelError.Visibility = Visibility.Collapsed;

            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Password;
            string repite = txtRepite.Password;

            if (usuario.Length < 3 || usuario.Contains(' '))
            {
                MostrarError("El usuario debe tener al menos 3 caracteres y no puede llevar espacios.");
                txtUsuario.Focus();
                return;
            }

            if (Usuarios.Existe(usuario))
            {
                MostrarError("Ese usuario ya existe. Elige otro nombre.");
                txtUsuario.Focus();
                return;
            }

            if (clave.Length < 6)
            {
                MostrarError("La contraseña debe tener al menos 6 caracteres.");
                txtClave.Focus();
                return;
            }

            if (clave != repite)
            {
                MostrarError("Las contraseñas no coinciden.");
                txtRepite.Clear();
                txtRepite.Focus();
                return;
            }

            Usuarios.Registrar(usuario, clave);
            ((MainWindow)Application.Current.MainWindow).IrA("Login.xaml");
        }

        private void IrLogin_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).IrA("Login.xaml");
        }

        private void MostrarError(string mensaje)
        {
            txtError.Text = mensaje;
            panelError.Visibility = Visibility.Visible;
        }
    }
}