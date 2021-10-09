using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV.Entidades;

namespace TP_PAV.Datos
{
    class ClienteDao
    {
        private Cliente MapeoCliente()
        {
            Cliente cliente = new Cliente
            {
                //Mapear aca
            };
            return cliente;
        }

        public IList<Cliente> ObtenerTodos()
        {
            List<Cliente> listadoClientes = new List<Cliente>();

            return listadoClientes;
        }

        public IList<Cliente> ObtenerClienteFiltro(Dictionary<string, object> parametros)
        {
            List<Cliente> listadoClientes = new List<Cliente>();

            return listadoClientes;
        }
    }
}
