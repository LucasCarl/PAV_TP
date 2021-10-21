using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV.Datos;
using TP_PAV.Entidades;

namespace TP_PAV.Negocio
{
    class ProyectoService
    {
        ProyectoDao proyectoDao;

        public ProyectoService()
        {
            proyectoDao = new ProyectoDao();
        }

        public IList<Proyecto> ObtenerProyectos(Dictionary<string, object> parametros = null)
        {
            return (parametros != null) ? proyectoDao.ObtenerProyectoFiltro(parametros) : proyectoDao.ObtenerTodos();
        }

        public bool NuevoProyecto(Proyecto proyectoNuevo)
        {
            return proyectoDao.NuevoProyecto(proyectoNuevo);
        }
        public bool ModificarProyecto(Proyecto proyectoModif, int id)
        {
            return proyectoDao.ModificarProyecto(proyectoModif, id);
        }
        public bool EliminarProyecto(Proyecto proyectoBorrar)
        {
            return proyectoDao.EliminarProyecto(proyectoBorrar);
        }

        public bool ExisteProyecto(int idProducto, string descripcion)
        {
            return proyectoDao.ExisteProyecto(idProducto, descripcion);
        }
    }
}
