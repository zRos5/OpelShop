using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace OpelShop
{
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
            Loaded += (s, e) =>
            {
                // Si el usuario viene de crear una cuenta, se le deja el usuario rellenado
                if (Usuarios.UltimoRegistrado != "")
                {
                    txtUsuario.Text = Usuarios.UltimoRegistrado;
                    txtOk.Text = "Cuenta creada. Ya puedes iniciar sesión.";
                    panelOk.Visibility = Visibility.Visible;
                    Usuarios.UltimoRegistrado = "";
                    txtPassword.Focus();
                }
                else
                {
                    txtUsuario.Focus();
                }
            };
        }

        private void Entrar_Click(object sender, RoutedEventArgs e)
        {
            panelError.Visibility = Visibility.Collapsed;
            panelOk.Visibility = Visibility.Collapsed;

            string usuario = txtUsuario.Text.Trim();
            string clave = txtPassword.Password;

            if (usuario == "")
            {
                MostrarError("Introduce tu usuario.");
                txtUsuario.Focus();
                return;
            }

            if (clave == "")
            {
                MostrarError("Introduce tu contraseña.");
                txtPassword.Focus();
                return;
            }

            if (!Usuarios.Validar(usuario, clave))
            {
                MostrarError("Usuario o contraseña incorrectos. Revisa los datos o crea una cuenta.");
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            // Acceso correcto: se guarda la sesión, se actualiza la cabecera y se va a Inicio
            Usuarios.IniciarSesion(usuario);
            var ventana = (MainWindow)Application.Current.MainWindow;
            ventana.ActualizarSesion();
            ventana.IrA("Inicio.xaml");
        }

        private void IrRegistro_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).IrA("Registro.xaml");
        }

        private void MostrarError(string mensaje)
        {
            txtError.Text = mensaje;
            panelError.Visibility = Visibility.Visible;
            Sacudir();
        }

        // Sacudida corta de la tarjeta cuando hay un error
        private void Sacudir()
        {
            var animacion = new DoubleAnimationUsingKeyFrames();
            double[] posiciones = { -8, 8, -6, 6, -3, 0 };
            for (int i = 0; i < posiciones.Length; i++)
            {
                animacion.KeyFrames.Add(new LinearDoubleKeyFrame(
                    posiciones[i],
                    KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(60 * (i + 1)))));
            }
            desplazamiento.BeginAnimation(TranslateTransform.XProperty, animacion);
        }
    }
}