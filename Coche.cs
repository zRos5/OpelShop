using System.Collections.Generic;
using System.Globalization;

namespace OpelShop
{
    public class Coche
    {
        public string Nombre { get; set; } = "";
        public string Tipo { get; set; } = "";
        public int Precio { get; set; }
        public bool EsNovedad { get; set; }
        public string Imagen { get; set; } = "";
        public string Descripcion { get; set; } = "";
        public List<string> Caracteristicas { get; set; } = new List<string>();

        public string PrecioTexto =>
            "Desde " + Precio.ToString("N0", new CultureInfo("es-ES")) + " €";

        public static List<Coche> Catalogo { get; } = new List<Coche>
        {
            new Coche
            {
                Nombre = "Corsa", Tipo = "Gasolina", Precio = 17900, Imagen = "Assets/Corsa.jpg",
                Descripcion = "Un compacto urbano ágil y fácil de aparcar, pensado para quien busca un coche práctico y económico para el día a día.",
                Caracteristicas = new List<string> { "Motor de gasolina", "Tamaño compacto", "Ideal para ciudad" }
            },
            new Coche
            {
                Nombre = "Frontera Hybrid", Tipo = "Híbrido", Precio = 24900, EsNovedad = true, Imagen = "Assets/Frontera.jpg",
                Descripcion = "Un SUV familiar con tecnología híbrida, mucho espacio interior y un consumo contenido tanto en ciudad como en carretera.",
                Caracteristicas = new List<string> { "Motorización híbrida", "Gran espacio interior", "Perfil SUV" }
            },
            new Coche
            {
                Nombre = "Mokka Electric", Tipo = "Eléctrico", Precio = 31900, EsNovedad = true, Imagen = "Assets/Mokka.jpg",
                Descripcion = "Un SUV compacto 100 % eléctrico, con diseño moderno y una conducción silenciosa y suave sin emisiones.",
                Caracteristicas = new List<string> { "Motor eléctrico", "Cero emisiones en conducción", "Diseño moderno" }
            },
            new Coche
            {
                Nombre = "Combo Electric", Tipo = "Eléctrico", Precio = 35900, Imagen = "Assets/Combo.jpg",
                Descripcion = "Un vehículo versátil para el trabajo diario: espacio de carga amplio y coste de uso reducido gracias a su motor eléctrico.",
                Caracteristicas = new List<string> { "Motor eléctrico", "Gran capacidad de carga", "Uso profesional y familiar" }
            },
            new Coche
            {
                Nombre = "Grandland Hybrid", Tipo = "Híbrido", Precio = 36900, Imagen = "Assets/Grandland.jpg",
                Descripcion = "Un SUV de tamaño medio con motorización híbrida, pensado para viajar con comodidad y reducir el consumo.",
                Caracteristicas = new List<string> { "Motorización híbrida", "Confort en viajes largos", "Perfil SUV" }
            },
            new Coche
            {
                Nombre = "Astra Electric", Tipo = "Eléctrico", Precio = 38900, EsNovedad = true, Imagen = "Assets/Astra.jpg",
                Descripcion = "Un compacto de línea deportiva en versión 100 % eléctrica, que combina dinamismo, tecnología y bajo coste de uso.",
                Caracteristicas = new List<string> { "Motor eléctrico", "Cero emisiones en conducción", "Estilo deportivo" }
            }
        };
    }
}