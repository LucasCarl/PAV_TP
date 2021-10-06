using System;
using System.Collections.Generic;
using System.Text;
using TPGrupo8.Entidades;
using System.Data;

namespace TPGrupo8.Datos
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

        public bool NuevoContacto(Contacto contacto)
        {
            string comandoSql = string.Concat("INSERT INTO Contactos (nombre, apellido, email, telefono, borrado) ",
                                                "VALUES (@nombre, @apellido, @email, @telefono, 0)");

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("nombre", contacto.Nombre);
            parametros.Add("apellido", contacto.Apellido);
            parametros.Add("email", contacto.Email);
            parametros.Add("Telefono", contacto.Telefono);

            return (DataManager.Instancia().EjecutarSQL(comandoSql, parametros) == 1);
        }

        public bool ModificarContacto(Contacto contacto, int id)
        {
            string comandoSql = "UPDATE Contactos SET nombre = @nombre, apellido = @apellido, email = @email, telefono = @telefono, borrado=0 WHERE id_contacto = @idContacto";

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("idContacto", id);
            parametros.Add("nombre", contacto.Nombre);
            parametros.Add("apellido", contacto.Apellido);
            parametros.Add("email", contacto.Email);
            parametros.Add("Telefono", contacto.Telefono);

            return (DataManager.Instancia().EjecutarSQL(comandoSql, parametros) == 1);
        }
        public bool EliminarContacto(Contacto contacto)
        {
            string comandoSql = "UPDATE Contactos SET borrado=1 WHERE id_contacto = @idContacto";
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("idContacto", contacto.IdContacto);

            return (DataManager.Instancia().EjecutarSQL(comandoSql, parametros) == 1);
        }
    }
}
