using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_PAV.Entidades;

namespace TP_PAV.Datos
{
    class ClienteDao
    {
        private Cliente MapeoCliente(DataRow fila)
        {
            Cliente cliente = new Cliente();
            cliente.IdCliente = Convert.ToInt32(fila["id_cliente"].ToString());
            cliente.Cuit = fila["cuit"].ToString();
            cliente.RazonSocial = fila["razon_social"].ToString();
            cliente.FechaAlta = Convert.ToDateTime(fila["fecha_alta"].ToString());
            cliente.Calle = fila["calle"].ToString();
            cliente.Numero = fila["numero"].ToString();

            cliente.Barrio = new Barrio();
            cliente.Barrio.IdBarrio = Convert.ToInt32(fila["id_barrio"].ToString());
            cliente.Barrio.Nombre = fila["Barrio"].ToString();

            cliente.Contacto = new Contacto();
            cliente.Contacto.IdContacto = Convert.ToInt32(fila["id_contacto"].ToString());
            cliente.Contacto.Nombre = fila["nombre"].ToString();
            cliente.Contacto.Apellido = fila["apellido"].ToString(); 
            cliente.Contacto.Email = fila["email"].ToString();
            cliente.Contacto.Telefono = fila["telefono"].ToString();

            return cliente;
        }

        public IList<Cliente> ObtenerTodos()
        {
            List<Cliente> listadoClientes = new List<Cliente>();

            string sqlComando = string.Concat("SELECT C.id_cliente, C.razon_social, C.cuit, C.fecha_alta, C.calle, C.numero, ",
                                              "B.nombre AS 'Barrio', CO.nombre, CO.apellido, CO.email, CO.telefono ,B.id_barrio, CO.id_contacto ",
                                              "FROM Clientes C LEFT JOIN Barrios B ON C.id_barrio = B.id_barrio ",
                                              "LEFT JOIN Contactos CO ON C.id_contacto = CO.id_contacto ",
                                              "WHERE C.borrado = 0 ");
            var resultadoConsulta = DataManager.Instancia().ConsultaSQL(sqlComando).Rows;
            foreach (DataRow fila in resultadoConsulta)
            {
                listadoClientes.Add(MapeoCliente(fila));
            }

            return listadoClientes;
        }

        public IList<Cliente> ObtenerClienteFiltro(Dictionary<string, object> parametros)
        {
            List<Cliente> listadoClientes = new List<Cliente>();

            string sqlComando = string.Concat("SELECT C.id_cliente, C.razon_social, C.cuit, C.fecha_alta, C.calle, C.numero, ",
                                              "B.nombre AS 'Barrio', CO.nombre, CO.apellido, CO.email, CO.telefono ,B.id_barrio, CO.id_contacto ",
                                              "FROM Clientes C LEFT JOIN Barrios B ON C.id_barrio = B.id_barrio ",
                                              "LEFT JOIN Contactos CO ON C.id_contacto = CO.id_contacto ",
                                              "WHERE C.borrado = 0 ");
            //Filtros
            if (parametros.ContainsKey("cuit"))
                sqlComando += " AND C.cuit LIKE '%' + @cuit + '%' ";
            if (parametros.ContainsKey("razon"))
                sqlComando += " AND C.razon_social LIKE '%' + @razon + '%' ";
            if (parametros.ContainsKey("fechaDesde"))
                sqlComando += " AND C.fecha_alta > @fechaDesde ";
            if (parametros.ContainsKey("fechaHasta"))
                sqlComando += " AND C.fecha_alta < @fechaHasta ";
            if (parametros.ContainsKey("calle"))
                sqlComando += " AND C.calle LIKE '%' + @calle + '%' ";
            if (parametros.ContainsKey("numero"))
                sqlComando += " AND C.numero LIKE '%' + @numero + '%' ";    //Cambiar para que busque numero exacto?
            if (parametros.ContainsKey("barrio"))
                sqlComando += " AND C.id_barrio = @barrio ";
            if (parametros.ContainsKey("nombreContacto"))
                sqlComando += " AND CO.nombre LIKE '%' + @nombreContacto + '%' ";
            if (parametros.ContainsKey("apellidoContacto"))
                sqlComando += " AND CO.apellido LIKE '%' + @apellidoContacto + '%' ";
            if (parametros.ContainsKey("emailContacto"))
                sqlComando += " AND CO.email LIKE '%' + @emailContacto + '%' ";
            if (parametros.ContainsKey("telefono"))
                sqlComando += " AND CO.telefono LIKE '%' + @telefonoContacto + '%' ";

            var resultadoConsulta = DataManager.Instancia().ConsultaSQL(sqlComando, parametros).Rows;

            foreach (DataRow fila in resultadoConsulta)
            {
                listadoClientes.Add(MapeoCliente(fila));
            }

            return listadoClientes;
        }

        public bool NuevoCliente(Cliente clienteNuevo)
        {
            string sqlComando = string.Concat("INSERT INTO Clientes (cuit, razon_social, fecha_alta, calle, numero, id_barrio, id_contacto, borrado) ",
                                                "VALUES (@cuit, @razon, @fechaAlta, @calle, @numero, @barrio, @contacto, 0)");

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("cuit", clienteNuevo.Cuit);
            parametros.Add("razon", clienteNuevo.RazonSocial);
            parametros.Add("fechaAlta", DateTime.Today);
            parametros.Add("calle", clienteNuevo.Calle);
            parametros.Add("numero", clienteNuevo.Numero);
            parametros.Add("barrio", clienteNuevo.Barrio.IdBarrio);
            parametros.Add("contacto", clienteNuevo.Contacto.IdContacto);

            return (DataManager.Instancia().EjecutarSQL(sqlComando, parametros) == 1);
        }

        public bool ModificarCliente(Cliente clienteModif, int id)
        {
            string sqlComando = string.Concat("UPDATE Clientes SET cuit = @cuit, razon_social = @razon, calle = @calle, numero = @numero, ",
                                                "id_barrio = @barrio, id_contacto = @contacto WHERE id_cliente = @idCliente");

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("idCliente", id);
            parametros.Add("cuit", clienteModif.Cuit);
            parametros.Add("razon", clienteModif.RazonSocial);
            parametros.Add("calle", clienteModif.Calle);
            parametros.Add("numero", clienteModif.Numero);
            parametros.Add("barrio", clienteModif.Barrio.IdBarrio);
            parametros.Add("contacto", clienteModif.Contacto.IdContacto);

            return (DataManager.Instancia().EjecutarSQL(sqlComando, parametros) == 1);
        }

        public bool EliminarCliente(Cliente clienteBorrar)
        {
            string sqlComando = "UPDATE Clientes SET borrado = 1 WHERE id_cliente = @idCliente";

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("idCliente", clienteBorrar.IdCliente);

            return (DataManager.Instancia().EjecutarSQL(sqlComando, parametros) == 1);
        }

        public Cliente TomarCliente(int id)
        {
            string sqlComando = string.Concat("SELECT C.id_cliente, C.razon_social, C.cuit, C.fecha_alta, C.calle, C.numero, ",
                                              "B.nombre AS 'Barrio', CO.nombre, CO.apellido, CO.email, CO.telefono ,B.id_barrio, CO.id_contacto ",
                                              "FROM Clientes C LEFT JOIN Barrios B ON C.id_barrio = B.id_barrio ",
                                              "LEFT JOIN Contactos CO ON C.id_contacto = CO.id_contacto ",
                                              "WHERE C.borrado = 0 ");

            var resultadoConsulta = DataManager.Instancia().ConsultaSQL(sqlComando).Rows;
            return MapeoCliente(resultadoConsulta[0]);
        }
    }
}
