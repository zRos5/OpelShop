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

        public string PrecioTexto =>
            "Desde " + Precio.ToString("N0", new CultureInfo("es-ES")) + " €";

        public static List<Coche> Catalogo { get; } = new List<Coche>
           {
               new Coche { Nombre = "Corsa", Tipo = "Gasolina", Precio = 17900, Imagen = "Assets/Corsa.jpg" },
               new Coche { Nombre = "Frontera Hybrid", Tipo = "Híbrido", Precio = 24900, EsNovedad = true, Imagen = "Assets/Frontera.jpg" },
               new Coche { Nombre = "Mokka Electric", Tipo = "Eléctrico", Precio = 31900, EsNovedad = true, Imagen = "Assets/Mokka.jpg" },
               new Coche { Nombre = "Combo Electric", Tipo = "Eléctrico", Precio = 35900, Imagen = "Assets/Combo.jpg" },
               new Coche { Nombre = "Grandland Hybrid", Tipo = "Híbrido", Precio = 36900, Imagen = "Assets/Grandland.jpg" },
               new Coche { Nombre = "Astra Electric", Tipo = "Eléctrico", Precio = 38900, EsNovedad = true, Imagen = "Assets/Astra.jpg" }
           };
    }
}