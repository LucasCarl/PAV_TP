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
        }

        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnBorrar.Enabled = true;
            btnEditar.Enabled = true;
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
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMBario abmBarrio = new frmABMBario();
            abmBarrio.IniciarFormulario(frmABMBario.FormMode.nuevo);
            abmBarrio.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmABMBario aBMBarrio = new frmABMBario();
            aBMBarrio.IniciarFormulario(frmABMBario.FormMode.modificar, (Barrio)dgvTabla.CurrentRow.DataBoundItem);
            aBMBarrio.ShowDialog();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            frmABMBario aBMBarrio = new frmABMBario();
            aBMBarrio.IniciarFormulario(frmABMBario.FormMode.eliminar, (Barrio)dgvTabla.CurrentRow.DataBoundItem);
            aBMBarrio.ShowDialog();
        }
    }
}
