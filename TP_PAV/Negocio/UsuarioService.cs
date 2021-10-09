using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV.Datos;

namespace TP_PAV.Negocio
{
    class UsuarioService
    {
        UsuarioDao usuDao = new UsuarioDao();
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
        public bool ValidarUsuario(string nombreUsuario, string password)
        {
            var usr = usuDao.ObtenerUsuario(nombreUsuario);
            if (usr != null && usr.Password.Equals(password))
            {
                return true;
            }
            return false;
        }
    }
}
