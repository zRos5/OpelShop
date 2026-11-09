using System.Windows;
using System.Windows.Input;

namespace OpelShop
{
    public partial class DetalleCoche : Window
    {
        public DetalleCoche(Coche coche)
        {
            InitializeComponent();
            DataContext = coche;
        }

        private void Cerrar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Ventana_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Close();
            }
        }
    }
}