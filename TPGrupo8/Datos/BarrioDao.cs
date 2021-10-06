using System;
using System.Collections.Generic;
using System.Text;
using TPGrupo8.Entidades;
using System.Data;

namespace TPGrupo8.Datos
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
            if(parametros.ContainsKey("nombre"))
                sqlComando += " AND nombre LIKE '%' + @nombre + '%' ";

            var resultadoConsulta = (DataRowCollection)DataManager.Instancia().ConsultaSQL(sqlComando).Rows;

            //Transforma filas en Barrios
            foreach (DataRow fila in resultadoConsulta)
            {
                listadoBarrios.Add(MapeoBarrio(fila));
            }

            return listadoBarrios;
        }
    }
}
