using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV.Datos;
using TP_PAV.Entidades;

namespace TP_PAV.Negocio
{
    class ClienteService
    {
        ClienteDao clienteDao;

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
