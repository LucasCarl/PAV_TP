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
    public partial class frmContactos : Form
    {
        ContactoService contactoService = new ContactoService();

        public frmContactos()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            IList<Contacto> lista;
            
            //Filtros
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            if (!String.IsNullOrEmpty(txtNombre.Text))
                parametros.Add("nombre", txtNombre.Text);
            if (!String.IsNullOrEmpty(txtApellido.Text))
                parametros.Add("apellido", txtApellido.Text);
            if (!String.IsNullOrEmpty(txtEmail.Text))
                parametros.Add("email", txtEmail.Text);
            if (!String.IsNullOrEmpty(txtTelefono.Text))
                parametros.Add("telefono", txtTelefono.Text);

            lista = contactoService.ObtenerContactos(parametros);

            dgvTabla.DataSource = lista;

            //Resetea botones borrar/editar
            btnBorrar.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnBorrar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMContacto abmContacto = new frmABMContacto();
            abmContacto.IniciarFormulario(frmABMContacto.FormMode.nuevo);
            abmContacto.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmABMContacto abmContacto = new frmABMContacto();
            abmContacto.IniciarFormulario(frmABMContacto.FormMode.modificar, (Contacto)dgvTabla.CurrentRow.DataBoundItem);
            abmContacto.ShowDialog();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            frmABMContacto abmContacto = new frmABMContacto();
            abmContacto.IniciarFormulario(frmABMContacto.FormMode.eliminar, (Contacto)dgvTabla.CurrentRow.DataBoundItem);
            abmContacto.ShowDialog();
        }
    }
}
