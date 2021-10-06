using System;
using System.Collections.Generic;
using System.Text;
using TPGrupo8.Datos;
using TPGrupo8.Entidades;

namespace TPGrupo8.Negocio
{
    class ContactoService
    {
        ContactoDao contactoDao = new ContactoDao();
        public ContactoService()
        {
            contactoDao = new ContactoDao();
        }

        public IList<Contacto> ObtenerContactos(Dictionary<string, object> parametros = null)
        {
            if(parametros != null)
                return contactoDao.ObtenerContactosFiltros(parametros);
            else
                return contactoDao.ObtenerTodos();
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
    }
}
