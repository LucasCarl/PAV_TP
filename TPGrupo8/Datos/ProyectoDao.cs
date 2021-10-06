using System;
using System.Collections.Generic;
using System.Text;
using TPGrupo8.Entidades;

namespace TPGrupo8.Datos
{
    class ProyectoDao
    {
        private Proyecto MapeoProyecto()
        {
            Proyecto proyecto = new Proyecto()
            {
                //Mapear aca
            };
            return proyecto;
        }

        public IList<Proyecto> ObtenerTodos()
        {
            List<Proyecto> listadoProyectos = new List<Proyecto>();


            return listadoProyectos;
        }

        public IList<Proyecto> ObtenerProyectoFiltro(Dictionary<string, object> parametros = null)
        {
            List<Proyecto> listadoProyectos = new List<Proyecto>();


            return listadoProyectos;
        }
    }
}
