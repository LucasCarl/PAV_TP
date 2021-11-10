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
using TP_PAV.Negocio;

namespace TP_PAV.Interfaz.Consultas
{
    public partial class frmBarrio : Form
    {
        BarrioService barrioService = new BarrioService();
        public frmBarrio()
        {
            InitializeComponent();
            InicializarDataGridView();
        }

        private void InicializarDataGridView()
        {
            //No permite generar columnas nuevas
            dgvTabla.AutoGenerateColumns = false;

            //Estilo celda de Headers
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = Color.Aquamarine;
            headerStyle.ForeColor = Color.Aquamarine;
            headerStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dgvTabla.ColumnHeadersDefaultCellStyle = headerStyle;
        }

        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnBorrar.Enabled = true;
                btnEditar.Enabled = true;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            IList<Barrio> lista;
            //Comprueba si hay que tomar filtros o no
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            if (!String.IsNullOrEmpty(txtNombre.Text))
                parametros.Add("nombre", txtNombre.Text);

            lista = barrioService.ObtenerBarrios(parametros);

            dgvTabla.DataSource = lista;

            //Resetea botones borrar/editar
            btnBorrar.Enabled = false;
            btnEditar.Enabled = false;
            //Muestra cantidad de filas
            lblFilas.Text = "Cantidad de resultados: " + lista.Count;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMBarrio abmBarrio = new frmABMBarrio();
            abmBarrio.IniciarFormulario(frmABMBarrio.FormMode.nuevo);
            abmBarrio.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmABMBarrio aBMBarrio = new frmABMBarrio();
            aBMBarrio.IniciarFormulario(frmABMBarrio.FormMode.modificar, (Barrio)dgvTabla.CurrentRow.DataBoundItem);
            aBMBarrio.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            frmABMBarrio aBMBarrio = new frmABMBarrio();
            aBMBarrio.IniciarFormulario(frmABMBarrio.FormMode.eliminar, (Barrio)dgvTabla.CurrentRow.DataBoundItem);
            aBMBarrio.ShowDialog();
            btnConsultar_Click(sender, e);
        }
    }
}
