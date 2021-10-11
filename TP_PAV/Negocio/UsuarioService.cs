using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_PAV.Datos;
using TP_PAV.Entidades;

namespace TP_PAV.Negocio
{
    class UsuarioService
    {
        UsuarioDao usuDao;
        public UsuarioService()
        {
            usuDao = new UsuarioDao();
        }

        /// <summary>
        ///     Checkea que el usuario exista y que esa sea su contraseña.
        /// </summary>
        /// <param name="nombreUsuario">Nombre del Usuario</param>
        /// <param name="password">Contraseña del Usuario</param>
        /// <returns>
        ///     <para><u>true</u> si es valido</para>
        ///     <para><u>false</u> si no es valido o no se encontro el usuario</para>    
        /// </returns>
        public Usuario ValidarUsuario(string nombreUsuario, string password)
        {
            var usr = usuDao.ObtenerUsuario(nombreUsuario);
            if (usr != null && usr.Password.Equals(password))
            {
                return usr;
            }
            return null;
        }

        public DataTable ListaUsuarios()
        {
            return DataManager.Instancia().ConsultaSQL("SELECT * FROM Usuarios WHERE borrado = 0");
        }
        public Usuario ObtenerUsuario(int id)
        {
            return usuDao.ObtenerUsuario(id);
        }
    }
}
