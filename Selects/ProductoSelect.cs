using GestionInventario_MySQL_.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInventario_MySQL_.Selects
{
    internal class ProductoSelect:Conexion
    {
        public ProductoSelect() { }

        public MySqlDataReader Lista(string campo, string tabla)
        {
            MySqlDataReader results;
            string sql = $"SELECT {campo} FROM {tabla}";
            try
            {
                Abrir();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                results = cmd.ExecuteReader();
                return results;
                
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int BuscarID(string tabla,string campo,string busqueda)
        {
            MySqlDataReader results;
            string sql = $"SELECT id{tabla} FROM {tabla} WHERE {campo}='{busqueda}'";
            try
            {
                Abrir();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                results = cmd.ExecuteReader();
                results.Read();
                return results.GetInt32(0);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //INNECESARIO NO SE NECESITA CIUDAD PARA GUARDAR PROVEEDORES
        public MySqlDataReader ListaCiudad(int iddepartamento)
        {
            MySqlDataReader results;
            string sql = $"SELECT nombre FROM ciudad WHERE iddepartamento={iddepartamento}";
            try
            {
                Abrir();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                results = cmd.ExecuteReader();
                return results;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public MySqlDataReader CargarProveedor()
        {
            MySqlDataReader results;
            string sql = "SELECT idproducto, idusuario, proveedor.nombre,marca.nombre,categoria.descripcion,condicion.descripcion,idalmacen,modelo,preciounitario,cantidad,total FROM producto,proveedor,marca,categoria,condicion WHERE producto.idproveedor = proveedor.idproveedor AND producto.idmarca = marca.idmarca AND producto.idcategoria = categoria.idcategoria AND producto.idcondicion = condicion.idcondicion;";
            try
            {
                Abrir();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                results = cmd.ExecuteReader();
                return results;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
