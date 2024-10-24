using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionInventario_MySQL_.Models;
using MySql.Data.MySqlClient;

namespace GestionInventario_MySQL_.DAO
{
    internal class UsuarioDAO : Conexion
    {
        public void Insertar(Usuario obj)
        {
            string sql = "INSERT INTO usuario(idrol,nombre,contra,cedulaidentidad) VALUES (@p1,@p2,@p3,@p4)";
            try
            {
                Abrir();
                MySqlCommand cmd = new MySqlCommand(sql,con);
                cmd.Parameters.AddWithValue("@p1", obj.rol);
                cmd.Parameters.AddWithValue("@p2",obj.nombre);
                cmd.Parameters.AddWithValue("@p3", obj.contra);
                cmd.Parameters.AddWithValue("@p4",obj.cedulaidentidad);
                cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Actualizar(int id,Usuario obj)
        {
            string sql = "UPDATE usuario SET idrol=@p1,nombre=@p2,contra=@p3,cedulaidentidad=@p4 WHERE idusuario=@p5";
            try
            {
                Abrir();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@p1", obj.rol);
                cmd.Parameters.AddWithValue("@p2", obj.nombre);
                cmd.Parameters.AddWithValue("@p3", obj.contra);
                cmd.Parameters.AddWithValue("@p4", obj.cedulaidentidad);
                cmd.Parameters.AddWithValue("@p5",id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Eliminar(int id)
        {
            string sql = "DELETE FROM usuario WHERE idusuario=@p1";
            try
            {
                Abrir();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@p1",id);
                cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
