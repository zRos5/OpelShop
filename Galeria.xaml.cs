using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace OpelShop
{
    public partial class Galeria : Page
    {
        public Galeria()
        {
            InitializeComponent();
            Mostrar("Todos");
        }

        private void Filtro_Changed(object sender, SelectionChangedEventArgs e)
        {
            // El evento salta mientras se carga la página; se ignora hasta que todo existe
            if (listaCoches == null || txtResultados == null) return;

            string tipo = (cmbTipo.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "Todos";
            Mostrar(tipo);
        }

        private void Mostrar(string tipo)
        {
            var coches = Coche.Catalogo.Where(c => tipo == "Todos" || c.Tipo == tipo).ToList();
            listaCoches.ItemsSource = coches;
            txtResultados.Text = coches.Count == 1 ? "1 modelo" : coches.Count + " modelos";
        }
    }
}