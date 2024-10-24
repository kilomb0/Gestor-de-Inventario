using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using GestionInventario_MySQL_.Models;

namespace GestionInventario_MySQL_.DAO
{
    internal class ProveedorDAO : Conexion
    {
        public ProveedorDAO() { }
        public void Insertar(Proveedor obj)
        {
            string sql = "INSERT INTO proveedor(idciudad,nombre,telefono,correo,documento) VALUES (@p5,@p1,@p2,@p3,@p4)";
            try
            {
                Abrir();
                MySqlCommand cmd = new MySqlCommand(sql,con);
                cmd.Parameters.AddWithValue("@p1", obj.nombre);
                cmd.Parameters.AddWithValue("@p2",obj.telefono);
                cmd.Parameters.AddWithValue("@p3", obj.correo);
                cmd.Parameters.AddWithValue("@p4",obj.documento);
                cmd.Parameters.AddWithValue("@p5",obj.idciudad);

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        } 
        
        public void Actualizar(int id,Proveedor obj)
        {
            string sql = "UPDATE proveedor SET idciudad=@p6,nombre=@p1,telefono=@p2,correo=@p3,documento=@p4 WHERE idproveedor=@p5";
            try
            {
                Abrir();
                MySqlCommand cmd = new MySqlCommand(sql,con);
                cmd.Parameters.AddWithValue("@p1", obj.nombre);
                cmd.Parameters.AddWithValue("@p2", obj.telefono);
                cmd.Parameters.AddWithValue("@p3", obj.correo);
                cmd.Parameters.AddWithValue("@p4", obj.documento);
                cmd.Parameters.AddWithValue("@p5",id);
                cmd.Parameters.AddWithValue("@p6", obj.idciudad);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Eliminar(int id)
        {
            string sql = "DELETE FROM proveedor WHERE idproveedor=@p1";
            try
            {
                Abrir();
                MySqlCommand cmd = new MySqlCommand(sql,con);
                cmd.Parameters.AddWithValue("@p1",id);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
