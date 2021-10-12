using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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

        public bool NuevoCliente(Cliente nuevoCliente)
        {
            return clienteDao.NuevoCliente(nuevoCliente);
        }
        public bool ModificarCliente(Cliente clienteModif, int id)
        {
            return clienteDao.ModificarCliente(clienteModif, id);
        }
        public bool EliminarCliente(Cliente borrarCliente)
        {
            return clienteDao.EliminarCliente(borrarCliente);
        }

        public Cliente TomarCliente(int id)
        {
            return clienteDao.TomarCliente(id);
        }

        public DataTable ListaClientes()
        {
            return DataManager.Instancia().ConsultaSQL("SELECT * FROM Clientes WHERE borrado = 0");
        }
    }
}
