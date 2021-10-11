using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_PAV.Entidades;

namespace TP_PAV.Datos
{
    class ContactoDao
    {

        public IList<Contacto> ObtenerTodos()
        {
            List<Contacto> listadoContactos = new List<Contacto>();

            //Consulta SQL
            String sqlComando = String.Concat("SELECT C.id_contacto AS 'ID', C.nombre AS Nombre, ",
                                                "C.apellido AS Apellido, C.email AS 'E-Mail', C.telefono AS Telefono ",
                                                "FROM Contactos C WHERE C.borrado = 0 ");

            var resultadoConsulta = (DataRowCollection)DataManager.Instancia().ConsultaSQL(sqlComando).Rows;

            //Tranforma filas en Consultas
            foreach (DataRow row in resultadoConsulta)
            {
                listadoContactos.Add(ObjectMapping(row));
            }

            return listadoContactos;
        }


        /// <summary>
        /// Obtiene lista de los contactos segun los parametros enviados
        /// </summary>
        public IList<Contacto> ObtenerContactosFiltros(Dictionary<string, object> parametros = null)
        {
            List<Contacto> listadoContactos = new List<Contacto>();

            //Consulta SQL
            String sqlComando = String.Concat("SELECT C.id_contacto AS 'ID', C.nombre AS Nombre, ",
                                                "C.apellido AS Apellido, C.email AS 'E-Mail', C.telefono AS Telefono ",
                                                "FROM Contactos C WHERE C.borrado = 0 ");
            //Filtros - Parametros
            if (parametros.ContainsKey("nombre"))
                sqlComando += " AND nombre LIKE '%' + @nombre + '%' ";
            if (parametros.ContainsKey("apellido"))
                sqlComando += " AND apellido LIKE '%' + @apellido + '%' ";
            if (parametros.ContainsKey("email"))
                sqlComando += " AND email LIKE '%' + @email + '%' ";
            if (parametros.ContainsKey("telefono"))
                sqlComando += " AND telefono LIKE '%' + @telefono + '%' ";

            var resultadoConsulta = (DataRowCollection)DataManager.Instancia().ConsultaSQL(sqlComando, parametros).Rows;

            //Tranforma filas en Consultas
            foreach (DataRow row in resultadoConsulta)
            {
                listadoContactos.Add(ObjectMapping(row));
            }

            return listadoContactos;
        }

        private Contacto ObjectMapping(DataRow fila)
        {
            Contacto contacto = new Contacto
            {
                IdContacto = Convert.ToInt32(fila["ID"].ToString()),
                Nombre = fila["Nombre"].ToString(),
                Apellido = fila["Apellido"].ToString(),
                Email = fila["E-mail"].ToString(),
                Telefono = fila["Telefono"].ToString()
            };
            return contacto;
        }

        public bool NuevoContacto(Contacto contactoNuevo)
        {
            string comandoSql = string.Concat("INSERT INTO Contactos (nombre, apellido, email, telefono, borrado) ",
                                                "VALUES (@nombre, @apellido, @email, @telefono, 0)");

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("nombre", contactoNuevo.Nombre);
            parametros.Add("apellido", contactoNuevo.Apellido);
            parametros.Add("email", contactoNuevo.Email);
            parametros.Add("Telefono", contactoNuevo.Telefono);

            return (DataManager.Instancia().EjecutarSQL(comandoSql, parametros) == 1);
        }

        public bool ModificarContacto(Contacto contactoModif, int id)
        {
            string comandoSql = "UPDATE Contactos SET nombre = @nombre, apellido = @apellido, email = @email, telefono = @telefono WHERE id_contacto = @idContacto";

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("idContacto", id);
            parametros.Add("nombre", contactoModif.Nombre);
            parametros.Add("apellido", contactoModif.Apellido);
            parametros.Add("email", contactoModif.Email);
            parametros.Add("Telefono", contactoModif.Telefono);

            return (DataManager.Instancia().EjecutarSQL(comandoSql, parametros) == 1);
        }
        public bool EliminarContacto(Contacto contactoBorrar)
        {
            string comandoSql = "UPDATE Contactos SET borrado = 1 WHERE id_contacto = @idContacto";
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("idContacto", contactoBorrar.IdContacto);

            return (DataManager.Instancia().EjecutarSQL(comandoSql, parametros) == 1);
        }
    }
}
