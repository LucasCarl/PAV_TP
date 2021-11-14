using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TP_PAV.Negocio;
using TP_PAV.Entidades;

namespace TP_PAV.Interfaz.Reportes
{
    public partial class frmListadoFacturas : Form
    {
        private Size sizeVentanaViejo;
        private Size sizeReportViejo;

        public frmListadoFacturas()
        {
            InitializeComponent();
        }

        private void frmListadoFacturas_Load(object sender, EventArgs e)
        {
            ClienteService clienteService = new ClienteService();
            LlenarCombobox(cbxCliente, clienteService.ObtenerClientes(), "razonSocial", "idCliente");

        }

        private void LlenarCombobox(ComboBox cbx, object source, string mostrar, string valor)
        {
            cbx.DataSource = source;        //Origen de datos
            cbx.DisplayMember = mostrar;    //Propiedad a mostrar
            cbx.ValueMember = valor;        //Ruta de acceso a propiedad
            cbx.SelectedIndex = -1;         //Indice para que no este elegido nada
        }

        #region Cambiar size report si cambia size ventana
        private void frmListadoFacturas_ResizeBegin(object sender, EventArgs e)
        {
            sizeVentanaViejo = this.Size;
            sizeReportViejo = rpvListadoFacturas.Size;
        }

        private void frmListadoFacturas_Resize(object sender, EventArgs e)
        {
            int x = this.Size.Width - sizeVentanaViejo.Width;
            int y = this.Size.Height - sizeVentanaViejo.Height;

            rpvListadoFacturas.Size = new Size(sizeReportViejo.Width + x, sizeReportViejo.Height + y);

        }
        #endregion

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Cargar parametros consulta
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            if (cbxCliente.SelectedIndex >= 0)
                parametros.Add("idCliente", cbxCliente.SelectedValue);
            if (chkFecha.Checked)
            {
                parametros.Add("fechaDesde", dtpFechaDesde.Value.Date);
                parametros.Add("fechaHasta", dtpFechaHasta.Value.Date);
            }

            FacturaService facturaService = new FacturaService();
            IList<Factura> listadoFacturas = facturaService.ObtenerFacturas(parametros);

            if(listadoFacturas.Count == 0)
            {
                MessageBox.Show("No se encontraron facturas con los parametros establecidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Crear tabla datos
            DataTable tablaFacturas = new DataTable();
            tablaFacturas.Columns.Add("NroFactura", typeof(int));
            tablaFacturas.Columns.Add("Cliente", typeof(string));
            tablaFacturas.Columns.Add("Monto", typeof(float));
            tablaFacturas.Columns.Add("Fecha", typeof(string));

            foreach (Factura factura in listadoFacturas)
            {
                DataRow fila = tablaFacturas.NewRow();
                fila["NroFactura"] = factura.NumeroFactura;
                fila["Cliente"] = factura.Cliente.ToString();
                fila["Monto"] = factura.Monto;
                fila["Fecha"] = factura.FechaAlta.ToShortDateString();
                tablaFacturas.Rows.Add(fila);
            }

            //Cargar reporte
            rpvListadoFacturas.LocalReport.DataSources.Clear();
            rpvListadoFacturas.LocalReport.DataSources.Add(new ReportDataSource("dsListadoFacturas", tablaFacturas));
            rpvListadoFacturas.RefreshReport();
            rpvListadoFacturas.SetDisplayMode(DisplayMode.PrintLayout);
            rpvListadoFacturas.ZoomMode = ZoomMode.Percent;
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaDesde.Enabled = chkFecha.Checked;
            dtpFechaHasta.Enabled = chkFecha.Checked;
        }
    }
}
