using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_PAV.Entidades;

namespace TP_PAV.Datos
{
    class BarrioDao
    {
        private Barrio MapeoBarrio(DataRow fila)
        {
            Barrio barrio = new Barrio
            {
                IdBarrio = Convert.ToInt32(fila["ID"].ToString()),
                Nombre = fila["Nombre"].ToString()
            };
            return barrio;
        }

        public IList<Barrio> ObtenerTodos()
        {
            List<Barrio> listadoBarrios = new List<Barrio>();

            //Consulta SQL
            string sqlComando = "SELECT B.id_barrio AS 'ID', B.nombre AS 'Nombre' FROM Barrios B WHERE B.borrado = 0";

            var resultadoConsulta = (DataRowCollection)DataManager.Instancia().ConsultaSQL(sqlComando).Rows;

            //Transforma filas en Barrios
            foreach (DataRow fila in resultadoConsulta)
            {
                listadoBarrios.Add(MapeoBarrio(fila));
            }

            return listadoBarrios;
        }

        public IList<Barrio> ObtenerBarriosFiltros(Dictionary<string, object> parametros)
        {
            List<Barrio> listadoBarrios = new List<Barrio>();

            //Consulta SQL
            string sqlComando = "SELECT B.id_barrio AS 'ID', B.nombre AS 'Nombre' FROM Barrios B WHERE B.borrado = 0";

            //Filtros - Parametros
            if (parametros.ContainsKey("nombre"))
                sqlComando += " AND nombre LIKE '%' + @nombre + '%' ";

            var resultadoConsulta = (DataRowCollection)DataManager.Instancia().ConsultaSQL(sqlComando, parametros).Rows;

            //Transforma filas en Barrios
            foreach (DataRow fila in resultadoConsulta)
            {
                listadoBarrios.Add(MapeoBarrio(fila));
            }

            return listadoBarrios;
        }

        public bool NuevoBarrio(Barrio barrio)
        {
            string sqlComando = "INSERT INTO Barrios (nombre, borrado) VALUES (@nombre, 0)";

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("nombre", barrio.Nombre);

            return (DataManager.Instancia().EjecutarSQL(sqlComando, parametros) == 1);
        }

        public bool ModificarBarrio(Barrio barrio, int id)
        {
            string sqlComando = "UPDATE Barrios SET nombre = @nombre WHERE id_barrio = @idBarrio";
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("idBarrio", id);
            parametros.Add("nombre", barrio.Nombre);

            return (DataManager.Instancia().EjecutarSQL(sqlComando, parametros) == 1);
        }

        public bool EliminarBarrio(Barrio barrio)
        {
            string sqlComando = "UPDATE Barrios SET borrado = 1 WHERE id_barrio = @idBarrio";
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("idBarrio", barrio.IdBarrio);

            return (DataManager.Instancia().EjecutarSQL(sqlComando, parametros) == 1);
        }

        public Barrio TomarBarrio(int id)
        {
            string sqlComando = "SELECT id_barrio AS 'ID', nombre AS 'Nombre' FROM Barrios WHERE id_barrio = " + id;
            var resultadoConsulta = (DataRowCollection)DataManager.Instancia().ConsultaSQL(sqlComando).Rows;
            return MapeoBarrio(resultadoConsulta[0]);
        }

        public bool ExisteBarrio(string nombre)
        {
            string sqlComando = "SELECT nombre FROM Barrios WHERE borrado = 0 AND nombre = '" + nombre + "'";
            int resultadoConsulta = DataManager.Instancia().ConsultaSQL(sqlComando).Rows.Count;
            return resultadoConsulta > 0;
        }
    }
}
