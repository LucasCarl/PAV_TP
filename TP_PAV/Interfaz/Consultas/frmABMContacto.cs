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
    public partial class frmABMContacto : Form
    {
        public enum FormMode { nuevo, eliminar, modificar };
        private FormMode modo = FormMode.nuevo;
        private ContactoService contactoService;
        private Contacto oContacto;

        public frmABMContacto()
        {
            InitializeComponent();
            contactoService = new ContactoService();
        }

        public void IniciarFormulario(FormMode opcion, Contacto contacto = null)
        {
            modo = opcion;
            oContacto = contacto;
        }

        private void frmABMContacto_Load(object sender, EventArgs e)
        {
            //Cambia dependiendo del modo
            switch (modo)
            {
                case FormMode.nuevo:
                    this.Text = "Nuevo Contacto";
                    btnAccion.Text = "Añadir";
                    break;

                case FormMode.eliminar:
                    this.Text = "Borrar Contacto";
                    btnAccion.Text = "Eliminar";
                    MostrarDatos();
                    txtTelefono.Enabled = false;
                    txtNombre.Enabled = false;
                    txtEmail.Enabled = false;
                    txtApellido.Enabled = false;
                    break;

                case FormMode.modificar:
                    this.Text = "Modificar Contacto";
                    btnAccion.Text = "Modificar";
                    MostrarDatos();
                    break;
            }
        }

        private void MostrarDatos()
        {
            if (oContacto != null)
            {
                txtApellido.Text = oContacto.Apellido;
                txtNombre.Text = oContacto.Nombre;
                txtEmail.Text = oContacto.Email;
                txtTelefono.Text = oContacto.Telefono;
            }
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            //Comprueba que los campos esten llenos
            if (ControlVacio())
            {
                MessageBox.Show("Debe llenar todos los campos antes de continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (modo)
            {
                case FormMode.nuevo:

                    if (contactoService.NuevoContacto(NuevoContacto()))
                    {
                        MessageBox.Show("Contacto Creado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al crear Contacto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case FormMode.eliminar:

                    if (MessageBox.Show("Seguro que desea eliminar el Contacto?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (contactoService.EliminarContacto(oContacto))
                        {
                            MessageBox.Show("Contacto Eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar contacto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    break;

                case FormMode.modificar:

                    if (contactoService.ModificarContacto(NuevoContacto(), oContacto.IdContacto))
                    {
                        MessageBox.Show("Contacto Modificado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar Contacto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }

            this.Close();
        }

        private Contacto NuevoContacto()
        {
            Contacto newContacto = new Contacto();
            newContacto.Nombre = txtNombre.Text;
            newContacto.Apellido = txtApellido.Text;
            newContacto.Email = txtEmail.Text;
            newContacto.Telefono = txtTelefono.Text;

            return newContacto;
        }

        private bool ControlVacio()
        {
            bool vacio = false;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.BackColor = Color.FromArgb(255, 120, 120);
                vacio = true;
            }
            else
                txtNombre.BackColor = Color.White;

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                txtApellido.BackColor = Color.FromArgb(255, 120, 120);
                vacio = true;
            }
            else
                txtApellido.BackColor = Color.White;

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.BackColor = Color.FromArgb(255, 120, 120);
                vacio = true;
            }
            else
                txtEmail.BackColor = Color.White;

            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                txtTelefono.BackColor = Color.FromArgb(255, 120, 120);
                vacio = true;
            }
            else
                txtTelefono.BackColor = Color.White;

            return vacio;
        }
    }
}
