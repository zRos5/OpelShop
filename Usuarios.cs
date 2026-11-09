using System;
using System.Collections.Generic;

namespace OpelShop
{
    public static class Usuarios
    {
        private static readonly Dictionary<string, string> cuentas =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                   { "cliente", "Opel2026" }
            };

        public static string UltimoRegistrado { get; set; } = "";

        public static bool Existe(string usuario) => cuentas.ContainsKey(usuario);

        public static void Registrar(string usuario, string clave)
        {
            cuentas[usuario] = clave;
            UltimoRegistrado = usuario;
        }

        public static bool Validar(string usuario, string clave) =>
            cuentas.TryGetValue(usuario, out var guardada) && guardada == clave;
    }
}