using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_PAV.Entidades;

namespace TP_PAV.Datos
{
    class UsuarioDao
    {
        /// <summary>
        ///     Busca el usuario
        /// </summary>
        /// <param name="nombreUsuario">Nombre del Usuario</param>
        public Usuario ObtenerUsuario(string nombreUsuario)
        {
            //Comando SQL
            String sqlComando = string.Concat(" SELECT id_usuario, ",
                                          "        usuario, ",
                                          "        email, ",
                                          "        password, ",
                                          "        p.id_perfil, ",
                                          "        p.nombre perfil ",
                                          "   FROM Usuarios u",
                                          "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil ",
                                          "  WHERE usuario = @usuario");
            var parametros = new Dictionary<string, object>();
            parametros.Add("usuario", nombreUsuario);

            DataTable resultado = DataManager.Instancia().ConsultaSQL(sqlComando, parametros);
            //Validar que resultado tenga al menos 1 fila
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;    //Si no encuentra ningun usuario devuelve null
        }

        private Usuario ObjectMapping(DataRow row)
        {
            Usuario oUsuario = new Usuario
            {
                IdUsuario = Convert.ToInt32(row["id_usuario"].ToString()),
                NombreUsuario = row["usuario"].ToString(),
                Email = row["email"].ToString(),
                Password = row.Table.Columns.Contains("password") ? row["password"].ToString() : null,
                Perfil = new Perfil()
                {
                    IdPerfil = Convert.ToInt32(row["id_perfil"].ToString()),
                    Nombre = row["perfil"].ToString(),
                }
            };

            return oUsuario;
        }

        public Usuario ObtenerUsuario(int id)
        {
            //Comando SQL
            String sqlComando = string.Concat(" SELECT id_usuario, ",
                                          "        usuario, ",
                                          "        email, ",
                                          "        password, ",
                                          "        p.id_perfil, ",
                                          "        p.nombre perfil ",
                                          "   FROM Usuarios u",
                                          "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil ",
                                          "  WHERE id_usuario = @idUsuario");
            var parametros = new Dictionary<string, object>();
            parametros.Add("idUsuario", id);

            DataTable resultado = DataManager.Instancia().ConsultaSQL(sqlComando, parametros);
            //Validar que resultado tenga al menos 1 fila
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;    //Si no encuentra ningun usuario devuelve null
        }
    }
}
