using System.Windows;

namespace OpelShop
{
    public partial class App : Application
    {
        private void Tarjeta_Click(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement elemento && elemento.DataContext is Coche coche)
            {
                var ventana = new DetalleCoche(coche) { Owner = Application.Current.MainWindow };
                ventana.ShowDialog();
            }
        }
    }
}