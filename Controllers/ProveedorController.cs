using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionInventario_MySQL_.Models;
using GestionInventario_MySQL_.DAO;

namespace GestionInventario_MySQL_.Controllers
{
    internal class ProveedorController
    {
        Proveedor proveedor = new Proveedor();
        ProveedorDAO dao = new ProveedorDAO();

        public ProveedorController()
        {

        }

        public void Agregar(string nombre, string documento, string telefono, string correo, int idciudad)
        {
            proveedor.idciudad = idciudad;
            proveedor.nombre = nombre;
            proveedor.documento = documento;
            proveedor.telefono = telefono;
            proveedor.correo = correo;
            dao.Insertar(proveedor);
        }

        public void Actualizar(int idproveedor, string nombre, string documento, string telefono, string correo, int idciudad)
        {
            proveedor.nombre = nombre;
            proveedor.documento = documento;
            proveedor.telefono = telefono;
            proveedor.idciudad = idciudad;
            proveedor.correo = correo;
            dao.Actualizar(idproveedor, proveedor);
        }

        public void Eliminar(int idproveedor)
        {
            dao.Eliminar(idproveedor);
        }
    }
}
