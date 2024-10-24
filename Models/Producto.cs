using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInventario_MySQL_.Models
{
    internal class Producto
    {
        public int idproveedor { get; set; }
        public int idusuario { get; set; }
        public int idmarca { get; set; }
        public int idcategoria { get; set; }
        public int idcondicion { get; set; }
        public int idalmacen { get; set; }
        public string modelo { get; set; }
        public double preciounitario { get; set; }
        public int cantidad { get; set; }

        public Producto()
        {

        }

        public Producto(int idproveedor, int idusuario, int idmarca, int idcategoria, int idcondicion, int idalmacen, string modelo, double preciounitario, int cantidad)
        {
            this.idproveedor = idproveedor;
            this.idusuario = idusuario;
            this.idmarca = idmarca;
            this.idcategoria = idcategoria;
            this.idcondicion = idcondicion;
            this.idalmacen = idalmacen;
            this.modelo = modelo;
            this.preciounitario = preciounitario;
            this.cantidad = cantidad;
        }
    }
}
