using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInventario_MySQL_.DAO
{
    internal class Conexion
    {
        protected MySqlConnection con;
        protected MySqlCommand cmd;
        protected MySqlDataReader dr;


        protected void Abrir()
        {
            try
            {
                string cadena = "Server=localhost;"
                    + "Port=3306;"
                    + "User id=root;"
                    + "Password = 1234;"
                    + "Database = inventario;";
                con = new MySqlConnection(cadena);
                con.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected void Cerrar()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
