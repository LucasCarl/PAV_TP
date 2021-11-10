using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV.Entidades;
using Microsoft.Reporting.WinForms;

namespace TP_PAV.Interfaz.Reportes
{
    public partial class frmReporteFactura : Form
    {
        private Factura factura;

        public frmReporteFactura(Factura fact)
        {
            factura = fact;
            InitializeComponent();
        }

        private void frmReporteFactura_Load(object sender, EventArgs e)
        {
            //Datos Factura
            ReportParameter nroFacturaParametro = new ReportParameter("prNroFactura", factura.NumeroFactura);
            ReportParameter fechaParametro = new ReportParameter("prFechaEmision", factura.FechaAlta.ToShortDateString());
            ReportParameter clienteCuitParametro = new ReportParameter("prClienteCuit", factura.Cliente.Cuit);
            ReportParameter clienteRazonParametro = new ReportParameter("prClienteRazon", factura.Cliente.RazonSocial);
            ReportParameter clienteDireccionParametro = new ReportParameter("prClienteDireccion", factura.Cliente.Direccion());
            rpvFactura.LocalReport.SetParameters(new ReportParameter[] { nroFacturaParametro, fechaParametro, clienteCuitParametro, clienteDireccionParametro, clienteRazonParametro });

            //Tabla de detalles
            DataTable tablaDetalles = new DataTable();
            tablaDetalles.Columns.Add("NumeroOrden");
            tablaDetalles.Columns.Add("Tipo");
            tablaDetalles.Columns.Add("Descripcion");
            tablaDetalles.Columns.Add("Precio", typeof(float));

            for (int i = 0; i < factura.ListadoDetalles.Count; i++)
            {
                DetalleFactura detalle = factura.ListadoDetalles[i];
                DataRow fila = tablaDetalles.NewRow();
                fila["NumeroOrden"] = detalle.NumeroOrden;
                fila["Precio"] = detalle.Precio;
                if (detalle.Producto != null)
                {
                    fila["Tipo"] = "Producto";
                    fila["Descripcion"] = detalle.Producto.ToString();
                }
                else
                {
                    fila["Tipo"] = "Proyecto";
                    fila["Descripcion"] = detalle.Proyecto.ToString();
                }
                tablaDetalles.Rows.Add(fila);
            }

            rpvFactura.LocalReport.DataSources.Clear();
            rpvFactura.LocalReport.DataSources.Add(new ReportDataSource("dsDetallesFacturas", tablaDetalles));
            rpvFactura.RefreshReport();
            rpvFactura.SetDisplayMode(DisplayMode.PrintLayout);
            rpvFactura.ZoomMode = ZoomMode.Percent;
        }
    }
}
