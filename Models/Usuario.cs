using Org.BouncyCastle.Asn1.Cms.Ecc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInventario_MySQL_.Models
{
    internal class Usuario
    {
        public int rol { get; set; }
        public string nombre { get; set; }
        public string contra { get; set; }
        public string cedulaidentidad { get; set; }

        public Usuario()
        {

        }
        public Usuario(string cedulaidentidad, string nombre, string contra, int rol)
        {
            this.nombre = nombre;
            this.contra = contra;
            this.rol = rol;
            this.cedulaidentidad = cedulaidentidad;
        }
    }
}
