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
            Loaded += (s, e) => txtUsuario.Focus();
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

            if (usuario != "cliente" || clave != "Opel2026")
            {
                MostrarError("Usuario o contraseña incorrectos. Revisa los datos e inténtalo de nuevo.");
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            panelOk.Visibility = Visibility.Visible;
        }

        private void MostrarError(string mensaje)
        {
            txtError.Text = mensaje;
            panelError.Visibility = Visibility.Visible;
            Sacudir();
        }

        // Animación 3: sacudida corta de la tarjeta cuando hay un error
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