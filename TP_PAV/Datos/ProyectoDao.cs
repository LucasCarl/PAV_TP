using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV.Entidades;

namespace TP_PAV.Datos
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
