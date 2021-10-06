using System;
using System.Collections.Generic;
using System.Text;
using TPGrupo8.Datos;
using TPGrupo8.Entidades;

namespace TPGrupo8.Negocio
{
    class ClienteService
    {
        ClienteDao clienteDao = new ClienteDao();

        public ClienteService()
        {
            clienteDao = new ClienteDao();
        }

        public IList<Cliente> ObtenerClientes(Dictionary<string, object> parametros = null)
        {
            return (parametros != null) ? clienteDao.ObtenerClienteFiltro(parametros) : clienteDao.ObtenerTodos();
        }
    }
}
