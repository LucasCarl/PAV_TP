using System;
using System.Collections.Generic;
using System.Text;
using TPGrupo8.Entidades;

namespace TPGrupo8.Datos
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
