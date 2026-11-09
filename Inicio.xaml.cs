using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace OpelShop
{
    public partial class Inicio : Page
    {
        public Inicio()
        {
            InitializeComponent();
            listaNovedades.ItemsSource = Coche.Catalogo.Where(c => c.EsNovedad).ToList();
            listaPrecios.ItemsSource = Coche.Catalogo.OrderBy(c => c.Precio).Take(3).ToList();

            if (Usuarios.HaySesion)
            {
                txtSaludo.Text = "Hola, " + Usuarios.UsuarioActual + ". Bienvenido de nuevo.";
                txtSaludo.Visibility = Visibility.Visible;
            }
        }

        private void VerProductos_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).IrA("Galeria.xaml");
        }
    }
}