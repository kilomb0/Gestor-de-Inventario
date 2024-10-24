using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionInventario_MySQL_.DAO;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace GestionInventario_MySQL_.Selects
{
    internal class UsuarioSelect : Conexion
    {
        public UsuarioSelect() { }

        public int Autenticar(string nombre, string contra)
        {
            int idusuario;
            string sql = "SELECT idusuario FROM usuario WHERE nombre=@p1 AND contra=@p2";
            try
            {
                Abrir();
                MySqlCommand cmd = new MySqlCommand(sql,con);
                cmd.Parameters.AddWithValue("@p1",nombre);
                cmd.Parameters.AddWithValue("@p2",contra);
                MySqlDataReader results = cmd.ExecuteReader();
                if (results.Read())
                {
                    idusuario=results.GetInt32(0);
                }
                else
                {
                    idusuario = -1;
                }
            }catch(Exception ex)
            {
                idusuario = -1;
                throw new Exception(ex.Message);
            }
            return idusuario;
        }

        public int BuscarID(string rol)
        {
            int idrol=0;
            string sql = $"SELECT idrol FROM rol WHERE descripcion='{rol}'";
            try
            {
                Abrir();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader results = cmd.ExecuteReader();
                if (results.Read())
                {
                    idrol = results.GetInt32(0);
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return idrol;
        }

        public int BuscarRol(int idusuario)
        {
            int idrol = 0;
            string sql = $"SELECT idrol FROM usuario WHERE idusuario=@p1";
            try
            {
                Abrir();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@p1",idusuario);
                MySqlDataReader results = cmd.ExecuteReader();
                if (results.Read())
                {
                    idrol = results.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return idrol;
        }


        public MySqlDataReader Lista()
        {
            string sql = "SELECT idusuario,rol.descripcion,usuario.nombre,contra,cedulaidentidad FROM usuario,rol WHERE usuario.idrol=rol.idrol ORDER BY idusuario ASC;";
            try
            {
                Abrir();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader results = cmd.ExecuteReader();
                return results;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
