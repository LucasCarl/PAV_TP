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
using TP_PAV.Entidades;

namespace TP_PAV.Interfaz.Consultas
{
    public partial class frmCliente : Form
    {
        private ClienteService clienteService = new ClienteService();
        private BarrioService barrioService = new BarrioService();

        public frmCliente()
        {
            InitializeComponent();
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaDesde.Enabled = !dtpFechaDesde.Enabled;
            dtpFechaHasta.Enabled = !dtpFechaHasta.Enabled;
            lblFechaHasta.Enabled = !lblFechaHasta.Enabled;
            lblFechaDesde.Enabled = !lblFechaDesde.Enabled;
        }

        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnBorrar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            //Llenar Combobox barrios
            cbxBarrio.DataSource = barrioService.ObtenerBarrios();
            cbxBarrio.DisplayMember = "nombre";
            cbxBarrio.ValueMember = "idBarrio";
            cbxBarrio.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            IList<Cliente> lista;

            //Comprueba filtros
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            if (!string.IsNullOrEmpty(txtCuit.Text))
                parametros.Add("cuit", txtCuit.Text);
            if (!string.IsNullOrEmpty(txtRazon.Text))
                parametros.Add("razon", txtRazon.Text);
            if (chkFecha.CheckState == CheckState.Checked)
            {
                parametros.Add("fechaDesde", dtpFechaDesde.Value);
                parametros.Add("fechaHasta", dtpFechaHasta.Value);
            }
            if (!string.IsNullOrEmpty(txtCalle.Text))
                parametros.Add("calle", txtCalle.Text);
            if (!string.IsNullOrEmpty(txtNombreC.Text))
                parametros.Add("numero", txtNumero.Text);
            if (!string.IsNullOrEmpty(cbxBarrio.Text))
                parametros.Add("barrio", cbxBarrio.SelectedValue);
            if (!string.IsNullOrEmpty(txtNombreC.Text))
                parametros.Add("nombreContacto", txtNombreC.Text);
            if (!string.IsNullOrEmpty(txtApellidoC.Text))
                parametros.Add("apellidoContacto", txtApellidoC.Text);
            if (!string.IsNullOrEmpty(txtEmailC.Text))
                parametros.Add("emailContacto", txtEmailC.Text);
            if (!string.IsNullOrEmpty(txtTelefonoC.Text))
                parametros.Add("telefonoContacto", txtTelefonoC.Text);

            lista = clienteService.ObtenerClientes(parametros);
            dgvTabla.DataSource = lista;
            //Resetear botones borrar edit
            btnBorrar.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMCliente abmCliente = new frmABMCliente();
            abmCliente.IniciarFormulario(frmABMCliente.FormMode.nuevo);
            abmCliente.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmABMCliente abmCliente = new frmABMCliente();
            abmCliente.IniciarFormulario(frmABMCliente.FormMode.modificar, (Cliente)dgvTabla.CurrentRow.DataBoundItem);
            abmCliente.ShowDialog();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            frmABMCliente abmCliente = new frmABMCliente();
            abmCliente.IniciarFormulario(frmABMCliente.FormMode.eliminar, (Cliente)dgvTabla.CurrentRow.DataBoundItem);
            abmCliente.ShowDialog();
        }
    }
}
