using System;
using System.Collections.Generic;
using System.Text;
using TPGrupo8.Datos;
using TPGrupo8.Entidades;

namespace TPGrupo8.Negocio
{
    class ProyectoService
    {
        ProyectoDao proyectoDao = new ProyectoDao();

        public ProyectoService()
        {
            proyectoDao = new ProyectoDao();
        }

        public IList<Proyecto> ObtenerProyectos(Dictionary<string, object> parametros = null)
        {
            return (parametros != null) ? proyectoDao.ObtenerProyectoFiltro(parametros) : proyectoDao.ObtenerTodos();
        }
    }
}
