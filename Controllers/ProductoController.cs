using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionInventario_MySQL_.Models;
using GestionInventario_MySQL_.DAO;

namespace GestionInventario_MySQL_.Controllers
{
    internal class ProductoController
    {
        Producto producto = new Producto();
        ProductoDAO dao = new ProductoDAO();

        public ProductoController()
        {

        }

        public void Agregar(int idproveedor,int idusuario,int idmarca, int idcategoria, int idcondicion, int idalmacen, string modelo, double preciounitario, int cantidad)
        {
            producto.idproveedor = idproveedor;
            producto.idusuario = idusuario;
            producto.idmarca = idmarca;
            producto.idcategoria = idcategoria;
            producto.idcondicion = idcondicion;
            producto.idalmacen = idalmacen;
            producto.modelo = modelo;
            producto.preciounitario = preciounitario;
            producto.cantidad = cantidad;
            dao.Insertar(producto);
        }
        public void Actualizar(int idproducto,int idproveedor, int idusuario, int idmarca, int idcategoria, int idcondicion, int idalmacen, string modelo, double preciounitario, int cantidad)
        {
            producto.idproveedor = idproveedor;
            producto.idusuario = idusuario;
            producto.idmarca = idmarca;
            producto.idcategoria = idcategoria;
            producto.idcondicion = idcondicion;
            producto.idalmacen = idalmacen;
            producto.modelo = modelo;
            producto.preciounitario = preciounitario;
            producto.cantidad = cantidad;
            dao.Actualizar(idproducto, producto);
        }

        public void Eliminar(int idproduto)
        {
            dao.Eliminar(idproduto);
        }
    }
}
