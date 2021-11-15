using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV.Negocio;
using TP_PAV.Interfaz.Reportes;
using TP_PAV.Entidades;

namespace TP_PAV.Interfaz.Consultas
{
    public partial class frmConsultaFacturas : Form
    {
        private FacturaService facturaService = new FacturaService();

        public frmConsultaFacturas()
        {
            InitializeComponent();
            InicializarDataGridView();
        }

        private void InicializarDataGridView()
        {
            //No permite generar columnas nuevas
            dgvFacturas.AutoGenerateColumns = false;

            //Estilo celda de Headers
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = Color.Aquamarine;
            headerStyle.ForeColor = Color.Aquamarine;
            headerStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dgvFacturas.ColumnHeadersDefaultCellStyle = headerStyle;
        }

        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnImprimir.Enabled = true;
            }
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            UsuarioService usuarioService = new UsuarioService();
            LlenarCombobox(cbxUsuario, usuarioService.ListaUsuarios(), "usuario", "id_usuario");

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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Factura factura = (Factura)dgvFacturas.CurrentRow.DataBoundItem;
            frmReporteFactura frmReporteFactura = new frmReporteFactura(factura);
            frmReporteFactura.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Controlar fecha desde < fecha hasta
            if (chkFecha.Checked && (dtpFechaDesde.Value.Date > dtpFechaHasta.Value.Date))
            {
                MessageBox.Show("La fecha desde debe ser anterior a la fecha hasta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Cargar parametros consulta
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            if (nudNroFactura.Value > 0)
                parametros.Add("nroFactura", nudNroFactura.Value);
            if (cbxCliente.SelectedIndex >= 0)
                parametros.Add("idCliente", cbxCliente.SelectedValue);
            if (cbxUsuario.SelectedIndex >= 0)
                parametros.Add("idUsuario", cbxUsuario.SelectedValue);
            if (chkFecha.Checked)
            {
                parametros.Add("fechaDesde", dtpFechaDesde.Value.Date);
                parametros.Add("fechaHasta", dtpFechaHasta.Value.Date);
            }

            IList<Factura> listadoFacturas = facturaService.ObtenerFacturas(parametros);
            dgvFacturas.DataSource = listadoFacturas;
            lblFilas.Text = "Cantidad de resultados: " + listadoFacturas.Count;

            btnImprimir.Enabled = false;
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaDesde.Enabled = !dtpFechaDesde.Enabled;
            dtpFechaHasta.Enabled = !dtpFechaHasta.Enabled;
            lblFechaHasta.Enabled = !lblFechaHasta.Enabled;
            lblFechaDesde.Enabled = !lblFechaDesde.Enabled;
        }

        private void dgvFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnImprimir.Enabled = true;
        }
    }
}
