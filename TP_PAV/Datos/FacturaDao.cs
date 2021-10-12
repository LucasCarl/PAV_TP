using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_PAV.Entidades;

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
            //Insertar Factura
            string sqlComandoFactura = string.Concat("INSERT INTO Facturas (numero_factura, id_cliente, fecha, id_usuario_creador, borrado) ",
                                                        "VALUES (@numeroFactura, @idCliente, @fechaAlta, @idUsuario, 0)");
            Dictionary<string, object> parametrosFactura = new Dictionary<string, object>();
            parametrosFactura.Add("numeroFactura", factura.NumeroFactura);
            parametrosFactura.Add("idCliente", factura.Cliente.IdCliente);
            parametrosFactura.Add("fechaAlta", factura.FechaAlta);
            parametrosFactura.Add("idUsuario", factura.UsuarioCreador.IdUsuario);
            DataManager.Instancia().EjecutarSQL(sqlComandoFactura, parametrosFactura);

            //Tomar idfactura
            string sqlIdFactura = "SELECT id_factura FROM Facturas WHERE numero_factura = " + factura.NumeroFactura;
            var resultadoConsulta = DataManager.Instancia().ConsultaSQL(sqlIdFactura);
            factura.IdFactura = Convert.ToInt32(resultadoConsulta.Rows[0]["id_factura"].ToString());

            //Insertar Detalle
            foreach (DetalleFactura detalle in factura.ListadoDetalles)
            {
                string sqlComandoDetalle = "";
                Dictionary<string, object> parametrosDetalle = new Dictionary<string, object>();
                parametrosDetalle.Add("idFactura", factura.IdFactura);
                parametrosDetalle.Add("numeroOrden", detalle.NumeroOrden);
                parametrosDetalle.Add("precio", detalle.Precio);
                if (detalle.Producto != null)
                {
                    sqlComandoDetalle = string.Concat("INSERT INTO FacturasDetalle (id_factura, numero_orden, id_producto, precio, borrado) ",
                                                        "VALUES (@idFactura, @numeroOrden, @idProducto, @precio, 0)");
                    parametrosDetalle.Add("idProducto", detalle.Producto.IdProducto);
                }
                if (detalle.Proyecto != null)
                {
                    sqlComandoDetalle = string.Concat("INSERT INTO FacturasDetalle (id_factura, numero_orden, id_proyecto, precio, borrado) ",
                                                        "VALUES (@idFactura, @numeroOrden,  @idProyecto, @precio, 0)");
                    parametrosDetalle.Add("idProyecto", detalle.Proyecto.IdProyecto);
                }

                DataManager.Instancia().EjecutarSQL(sqlComandoDetalle, parametrosDetalle);
            }

            return true;
        }
    }
}
