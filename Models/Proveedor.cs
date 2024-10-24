using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInventario_MySQL_.Models
{
    internal class Proveedor
    {
        public int idciudad { get; set; }
        public string nombre { get; set; }
        public string documento { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }

        public Proveedor()
        {

        }
    }
}
