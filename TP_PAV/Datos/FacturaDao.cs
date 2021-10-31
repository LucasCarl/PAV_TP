﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_PAV.Entidades;
using System.Data.SqlClient;

namespace TP_PAV.Datos
{
    class FacturaDao
    {
        public int UltimaFactura()
        {
            string sqlComand = "SELECT TOP 1 numero_factura FROM Facturas WHERE borrado = 0 ORDER BY numero_factura DESC";

            var resultadoConsulta = DataManager.Instancia().ConsultaSQL(sqlComand).Rows;
            if (resultadoConsulta.Count == 1)
                return Convert.ToInt32(resultadoConsulta[0]["numero_factura"].ToString());
            else
                return 0;
        }

        public bool CargarFactura(Factura factura)
        {
            SqlConnection dbConexion = new SqlConnection();
            SqlTransaction transaccion = null;
            try
            {
                //Conexion a DB
                dbConexion.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=BugTrackerTP;Integrated Security=true;";
                dbConexion.Open();
                //Genero transaccion
                transaccion = dbConexion.BeginTransaction();

                //Insertar Factura
                SqlCommand facturaInsert = new SqlCommand();
                facturaInsert.Connection = dbConexion;
                facturaInsert.CommandType = CommandType.Text;
                facturaInsert.Transaction = transaccion;

                facturaInsert.CommandText = string.Concat("INSERT INTO Facturas (numero_factura, id_cliente, fecha, id_usuario_creador, borrado) ",
                                                            "VALUES (@numeroFactura, @idCliente, @fechaAlta, @idUsuario, 0)");
                facturaInsert.Parameters.AddWithValue("numeroFactura", factura.NumeroFactura);
                facturaInsert.Parameters.AddWithValue("idCliente", factura.Cliente.IdCliente);
                facturaInsert.Parameters.AddWithValue("fechaAlta", factura.FechaAlta);
                facturaInsert.Parameters.AddWithValue("idUsuario", factura.UsuarioCreador.IdUsuario);

                facturaInsert.ExecuteNonQuery();

                //Tomar idfactura
                SqlCommand idfacturaSelect = new SqlCommand();
                idfacturaSelect.Connection = dbConexion;
                idfacturaSelect.CommandType = CommandType.Text;
                idfacturaSelect.Transaction = transaccion;
                idfacturaSelect.CommandText = "SELECT id_factura FROM Facturas WHERE numero_factura = " + factura.NumeroFactura;
                DataTable resultadoConsulta = new DataTable();
                resultadoConsulta.Load(idfacturaSelect.ExecuteReader());
                factura.IdFactura = Convert.ToInt32(resultadoConsulta.Rows[0]["id_factura"].ToString());

                //Insertar Detalle
                foreach (DetalleFactura detalle in factura.ListadoDetalles)
                {
                    SqlCommand detalleInsert = new SqlCommand();
                    detalleInsert.Connection = dbConexion;
                    detalleInsert.CommandType = CommandType.Text;
                    detalleInsert.Transaction = transaccion;

                    detalleInsert.Parameters.AddWithValue("idFactura", factura.IdFactura);
                    detalleInsert.Parameters.AddWithValue("numeroOrden", detalle.NumeroOrden);
                    detalleInsert.Parameters.AddWithValue("precio", detalle.Precio);
                    if (detalle.Producto != null)
                    {
                        detalleInsert.CommandText = string.Concat("INSERT INTO FacturasDetalle (id_factura, numero_orden, id_producto, precio, borrado) ",
                                                            "VALUES (@idFactura, @numeroOrden, @idProducto, @precio, 0)");
                        detalleInsert.Parameters.AddWithValue("idProducto", detalle.Producto.IdProducto);
                    }
                    if (detalle.Proyecto != null)
                    {
                        detalleInsert.CommandText = string.Concat("INSERT INTO FacturasDetalle (id_factura, numero_orden, id_proyecto, precio, borrado) ",
                                                            "VALUES (@idFactura, @numeroOrden,  @idProyecto, @precio, 0)");
                        detalleInsert.Parameters.AddWithValue("idProyecto", detalle.Proyecto.IdProyecto);
                    }

                    detalleInsert.ExecuteNonQuery();
                }

                //Commitear transaccion
                transaccion.Commit();
            }
            catch (Exception e)
            {
                transaccion.Rollback();
                throw e;
            }
            finally
            {
                //Cierra la conexion si se pudo abrir
                if (dbConexion.State != ConnectionState.Closed)
                {
                    dbConexion.Close();
                }
            }
            
            return true;
        }


        private Factura MapeoFactura(DataRow fila)
        {
            Factura factura = new Factura();
            factura.IdFactura = Convert.ToInt32(fila["id_factura"].ToString());
            factura.NumeroFactura = fila["numero_factura"].ToString();
            factura.FechaAlta = Convert.ToDateTime(fila["fecha"].ToString());
            
            ClienteDao clienteDao = new ClienteDao();
            factura.Cliente = clienteDao.TomarCliente(Convert.ToInt32(fila["id_cliente"].ToString()));
            
            UsuarioDao usuarioDao = new UsuarioDao();
            factura.UsuarioCreador = usuarioDao.ObtenerUsuario(Convert.ToInt32(fila["id_usuario_creador"].ToString()));

            //Detalles
            factura.ListadoDetalles = new List<DetalleFactura>();
            string sqlComandoDetalles = string.Concat("SELECT D.id_detalle_factura, D.numero_orden, D.precio , ",
                                                      "PD.id_producto AS 'ProductoID' , PD.nombre AS 'ProductoNombre' , ",
                                                      "PY.id_proyecto AS 'ProyectoID' , PY.descripcion AS 'ProyectoDescripcion' ",
                                                      "FROM FacturasDetalle D LEFT JOIN Productos PD ON D.id_producto = PD.id_producto ",
                                                      "LEFT JOIN Proyectos PY ON D.id_proyecto = PY.id_proyecto ",
                                                      "WHERE id_factura = ", Convert.ToInt32(fila["id_factura"].ToString()), " ORDER BY numero_orden");
            var resultadoConsulta = DataManager.Instancia().ConsultaSQL(sqlComandoDetalles).Rows;
            foreach(DataRow filaDetalle in resultadoConsulta)
            {
                DetalleFactura detalle = new DetalleFactura();
                detalle.IdDetalleFactura = Convert.ToInt32(filaDetalle["id_detalle_factura"].ToString());
                detalle.NumeroOrden = Convert.ToInt32(filaDetalle["numero_orden"].ToString());
                detalle.Precio = float.Parse(filaDetalle["precio"].ToString());
                if(filaDetalle["ProductoID"] != DBNull.Value)
                {
                    detalle.Producto = new Producto();
                    detalle.Producto.IdProducto = Convert.ToInt32(filaDetalle["ProductoID"].ToString());
                    detalle.Producto.Nombre = filaDetalle["ProductoNombre"].ToString();
                }
                if(filaDetalle["ProyectoID"] != DBNull.Value)
                {
                    var xdfbasjklfasdjfh = filaDetalle["ProyectoID"].GetType();
                    detalle.Proyecto = new Proyecto();
                    detalle.Proyecto.IdProyecto = Convert.ToInt32(filaDetalle["ProyectoID"].ToString());
                    detalle.Proyecto.Descripcion = filaDetalle["ProyectoDescripcion"].ToString();
                }

                factura.ListadoDetalles.Add(detalle);
            }

            return factura;
        }

        public IList<Factura> ObtenerTodas()
        {
            IList<Factura> listadoFacturas = new List<Factura>();
            string sqlComand = string.Concat("SELECT id_factura, numero_factura, id_cliente, fecha, id_usuario_creador ",
                                             "FROM Facturas ORDER BY numero_factura");

            var resultadoConsulta = DataManager.Instancia().ConsultaSQL(sqlComand).Rows;

            foreach (DataRow fila in resultadoConsulta)
            {
                listadoFacturas.Add(MapeoFactura(fila));
            }
            return listadoFacturas;
        }
    
    }
}
