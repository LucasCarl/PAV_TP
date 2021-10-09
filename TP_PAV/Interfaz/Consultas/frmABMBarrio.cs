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
    public partial class frmABMBarrio : Form
    {
        public enum FormMode { nuevo, eliminar, modificar };
        private FormMode modo = FormMode.nuevo;
        private BarrioService barrioService;
        private Barrio oBarrio;

        public frmABMBarrio()
        {
            InitializeComponent();
            barrioService = new BarrioService();
        }

        public void IniciarFormulario(FormMode opcion, Barrio barrio = null)
        {
            modo = opcion;
            oBarrio = barrio;
        }

        private void frmABMBario_Load(object sender, EventArgs e)
        {
            //Cambia dependiendo del modo
            switch (modo)
            {
                case FormMode.nuevo:
                    this.Text = "Nuevo Barrio";
                    btnAccion.Text = "Añadir";
                    break;

                case FormMode.eliminar:
                    this.Text = "Borrar Barrio";
                    btnAccion.Text = "Eliminar";
                    MostrarDatos();
                    txtNombre.Enabled = false;
                    break;

                case FormMode.modificar:
                    this.Text = "Modificar Barrio";
                    btnAccion.Text = "Modificar";
                    MostrarDatos();
                    break;
            }
        }

        private void MostrarDatos()
        {
            if (oBarrio != null)
                txtNombre.Text = oBarrio.Nombre;
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            //Comprueba que el campo este lleno
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe llenar todos los campos antes de continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (modo)
            {
                case FormMode.nuevo:

                    if (barrioService.NuevoBarrio(NuevoBarrio()))
                    {
                        MessageBox.Show("Barrio Creado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al crear Barrio", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case FormMode.eliminar:

                    if (MessageBox.Show("Seguro que desea eliminar el Contacto?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (barrioService.EliminarBarrio(oBarrio))
                        {
                            MessageBox.Show("Barrio Eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar Barrio", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    break;

                case FormMode.modificar:

                    if (barrioService.ModificarBarrio(NuevoBarrio(), oBarrio.IdBarrio))
                    {
                        MessageBox.Show("Barrio Modificado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar Barrio", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }

            this.Close();
        }

        private Barrio NuevoBarrio()
        {
            Barrio barrioNuevo = new Barrio();
            barrioNuevo.Nombre = txtNombre.Text;
            return barrioNuevo;
        }
    }
}
