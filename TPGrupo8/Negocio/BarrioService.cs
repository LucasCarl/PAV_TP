using System;
using System.Collections.Generic;
using System.Text;
using TPGrupo8.Datos;
using TPGrupo8.Entidades;

namespace TPGrupo8.Negocio
{
    class BarrioService
    {
        BarrioDao barrioDao = new BarrioDao();

        public BarrioService()
        {
            barrioDao = new BarrioDao();
        }

        public IList<Barrio> ObtenerBarrios(Dictionary<string, object> parametros = null)
        {
            return (parametros != null) ? barrioDao.ObtenerBarriosFiltros(parametros) : barrioDao.ObtenerTodos();
        }

        public bool NuevoBarrio(Barrio barrio)
        {
            return barrioDao.NuevoBarrio(barrio);
        }

        public bool ModificarBarrio(Barrio barrio, int id)
        {
            return barrioDao.ModificarBarrio(barrio, id);
        }

        public bool EliminarBarrio(Barrio barrio)
        {
            return barrioDao.EliminarBarrio(barrio);
        }
    }
}
