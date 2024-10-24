using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionInventario_MySQL_.Models;

namespace GestionInventario_MySQL_.DAO
{
    internal class ProductoDAO : Conexion
    {
        public ProductoDAO() { }

        public void Insertar(Producto obj)
        {
            string sql = "INSERT INTO producto(idproveedor,idusuario,idmarca,idcategoria,idcondicion,idalmacen,modelo,preciounitario,cantidad) VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)";
            try
            {
                Abrir();
                MySqlCommand cmd = new MySqlCommand(sql,con);
                cmd.Parameters.AddWithValue("@p1",obj.idproveedor);
                cmd.Parameters.AddWithValue("@p2", obj.idusuario);
                cmd.Parameters.AddWithValue("@p3", obj.idmarca);
                cmd.Parameters.AddWithValue("@p4", obj.idcategoria);
                cmd.Parameters.AddWithValue("@p5", obj.idcondicion);
                cmd.Parameters.AddWithValue("@p6", obj.idalmacen);
                cmd.Parameters.AddWithValue("@p7", obj.modelo);
                cmd.Parameters.AddWithValue("@p8", obj.preciounitario);
                cmd.Parameters.AddWithValue("@p9", obj.cantidad);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Actualizar(int idproducto,Producto obj)
        {
            string sql = "UPDATE producto SET idproveedor=@p1,idusuario=@p2,idmarca=@p3,idcategoria=@p4,idcondicion=@p5,idalmacen=@p6,modelo=@p7,preciounitario=@p8,cantidad=@p9 WHERE idproducto=@p10";
            try
            {
                Abrir();
                MySqlCommand cmd = new MySqlCommand(sql,con);
                cmd.Parameters.AddWithValue("@p1", obj.idproveedor);
                cmd.Parameters.AddWithValue("@p2", obj.idusuario);
                cmd.Parameters.AddWithValue("@p3", obj.idmarca);
                cmd.Parameters.AddWithValue("@p4", obj.idcategoria);
                cmd.Parameters.AddWithValue("@p5", obj.idcondicion);
                cmd.Parameters.AddWithValue("@p6", obj.idalmacen);
                cmd.Parameters.AddWithValue("@p7", obj.modelo);
                cmd.Parameters.AddWithValue("@p8", obj.preciounitario);
                cmd.Parameters.AddWithValue("@p9", obj.cantidad);
                cmd.Parameters.AddWithValue("@p10",idproducto);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }
        }

        public void Eliminar(int idproducto)
        {
            string sql = "DELETE FROM producto WHERE idproducto=@p1";
            try
            {
                Abrir();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@p1", idproducto);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
