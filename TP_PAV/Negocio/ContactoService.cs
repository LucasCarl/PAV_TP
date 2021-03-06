using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV.Entidades;
using TP_PAV.Datos;

namespace TP_PAV.Negocio
{
    class ContactoService
    {
        ContactoDao contactoDao;
        public ContactoService()
        {
            contactoDao = new ContactoDao();
        }

        public IList<Contacto> ObtenerContactos(Dictionary<string, object> parametros = null)
        {
            return (parametros != null) ? contactoDao.ObtenerContactosFiltros(parametros) : contactoDao.ObtenerTodos();
        }

        public Contacto TomarContacto(int id)
        {
            return contactoDao.TomarContacto(id);
        }

        public bool NuevoContacto(Contacto contacto)
        {
            return contactoDao.NuevoContacto(contacto);
        }

        public bool ModificarContacto(Contacto contacto, int id)
        {
            return contactoDao.ModificarContacto(contacto, id);
        }

        public bool EliminarContacto(Contacto contacto)
        {
            return contactoDao.EliminarContacto(contacto);
        }

        public bool ExisteContacto(string nombre, string apellido)
        {
            return contactoDao.ExisteContacto(nombre, apellido);
        }
    }
}
