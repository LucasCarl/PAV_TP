using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV.Entidades;
using TP_PAV.Datos;

namespace TP_PAV.Negocio
{
    class BarrioService
    {
        BarrioDao barrioDao;

        public BarrioService()
        {
            barrioDao = new BarrioDao();
        }

        public IList<Barrio> ObtenerBarrios(Dictionary<string, object> parametros = null)
        {
            return (parametros != null) ? barrioDao.ObtenerBarriosFiltros(parametros) : barrioDao.ObtenerTodos();
        }

        public Barrio TomarBarrio(int id)
        {
            return barrioDao.TomarBarrio(id);
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
