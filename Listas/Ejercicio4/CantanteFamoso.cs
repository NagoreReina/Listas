using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    class CantanteFamoso
    {
        public string Nombre { get; set; }
        public string DiscoMasFamoso { get; set; }

        public CantanteFamoso(string nombre, string discoMasFamoso)
        {
            Nombre = nombre;
            DiscoMasFamoso = discoMasFamoso;
        }
    }
}
