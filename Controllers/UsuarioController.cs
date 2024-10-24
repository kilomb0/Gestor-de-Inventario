using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionInventario_MySQL_.DAO;
using GestionInventario_MySQL_.Models;

namespace GestionInventario_MySQL_.Controllers
{
    internal class UsuarioController
    {
        Usuario user = new Usuario();
        UsuarioDAO dao = new UsuarioDAO();

        public void Agregar(int idrol, string nombre, string contra, string cedulaidentidad)
        {
            user.rol = idrol;
            user.nombre = nombre;
            user.contra = contra;
            user.cedulaidentidad= cedulaidentidad;
            dao.Insertar(user);
        }


        public void Actualizar(int idusuario,int idrol,string nombre,string contra,string cedulaidentidad)
        {
            user.rol = idrol;
            user.nombre = nombre;
            user.contra = contra;
            user.cedulaidentidad = cedulaidentidad;
            dao.Actualizar(idusuario,user);
        }

        public void Eliminar(int idusuario)
        {
            dao.Eliminar(idusuario);
        }
    }
}
