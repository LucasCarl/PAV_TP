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
            InicializarDataGridView();
        }

        private void InicializarDataGridView()
        {
            //No permite generar columnas nuevas
            dgvTabla.AutoGenerateColumns = false;

            //Agregar columna con botones para mostrar los datos de los contactos
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "Botones";
            btnColumn.Text = "Mostrar Datos";
            btnColumn.UseColumnTextForButtonValue = true;
            dgvTabla.Columns.Add(btnColumn);

            //Estilo celda de Headers
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = Color.Aquamarine;
            headerStyle.ForeColor = Color.Aquamarine;
            headerStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dgvTabla.ColumnHeadersDefaultCellStyle = headerStyle;

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
            if (e.RowIndex >= 0)
            {
                btnBorrar.Enabled = true;
                btnEditar.Enabled = true;

                //Detecta si se apreto la columna de botones
                if (e.ColumnIndex == dgvTabla.Columns.Count - 1)
                {
                    int fila = e.RowIndex;
                    Cliente cliente = (Cliente)dgvTabla.Rows[fila].DataBoundItem;
                    frmABMContacto abmContacto = new frmABMContacto();
                    abmContacto.IniciarFormulario(frmABMContacto.FormMode.mostrar, cliente.Contacto);
                    abmContacto.ShowDialog();
                }
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            //Llenar Combobox barrios
            cbxBarrio.DataSource = barrioService.ObtenerBarrios();
            cbxBarrio.DisplayMember = "nombre";
            cbxBarrio.ValueMember = "idBarrio";
            cbxBarrio.SelectedIndex = -1;

            btnConsultar_Click(sender, e);
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
            //Muestra cantidad de filas
            lblFilas.Text = "Cantidad de resultados: " + lista.Count;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMCliente abmCliente = new frmABMCliente();
            abmCliente.IniciarFormulario(frmABMCliente.FormMode.nuevo);
            abmCliente.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmABMCliente abmCliente = new frmABMCliente();
            abmCliente.IniciarFormulario(frmABMCliente.FormMode.modificar, (Cliente)dgvTabla.CurrentRow.DataBoundItem);
            abmCliente.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            frmABMCliente abmCliente = new frmABMCliente();
            abmCliente.IniciarFormulario(frmABMCliente.FormMode.eliminar, (Cliente)dgvTabla.CurrentRow.DataBoundItem);
            abmCliente.ShowDialog();
            btnConsultar_Click(sender, e);
        }
    }
}
