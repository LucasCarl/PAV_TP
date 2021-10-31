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
            //Tabla de detalles
            DataTable tablaDetalles = new DataTable();
            tablaDetalles.Columns.Add("nroOrden");
            tablaDetalles.Columns.Add("tipo");
            tablaDetalles.Columns.Add("descripcion");
            tablaDetalles.Columns.Add("precio");

            for (int i = 0; i < factura.ListadoDetalles.Count; i++)
            {
                DetalleFactura detalle = factura.ListadoDetalles[i];
                DataRow fila = tablaDetalles.NewRow();
                fila["nroOrden"] = detalle.NumeroOrden;
                fila["precio"] = detalle.Precio;
                if (detalle.Producto != null)
                {
                    fila["tipo"] = "Producto";
                    fila["descripcion"] = detalle.Producto.ToString();
                }
                else
                {
                    fila["tipo"] = "Proyecto";
                    fila["descripcion"] = detalle.Proyecto.ToString();
                }
                tablaDetalles.Rows.Add(fila);
            }

            rpvFactura.LocalReport.DataSources.Clear();
            rpvFactura.LocalReport.DataSources.Add(new ReportDataSource("dsFacturas", tablaDetalles));
            rpvFactura.RefreshReport();
        }
    }
}
