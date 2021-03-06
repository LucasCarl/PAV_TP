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

                    if(barrioService.ExisteBarrio(txtNombre.Text))
                    {
                        MessageBox.Show("Ya existe un barrio con el nombre ingresado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (barrioService.NuevoBarrio(NuevoBarrio()))
                        MessageBox.Show("Barrio creado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Error al crear barrio", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case FormMode.eliminar:

                    if (MessageBox.Show("Seguro que desea eliminar el barrio?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (barrioService.EliminarBarrio(oBarrio))
                            MessageBox.Show("Barrio eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Error al eliminar barrio", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case FormMode.modificar:

                    if (txtNombre.Text != oBarrio.Nombre && barrioService.ExisteBarrio(txtNombre.Text))
                    {
                        MessageBox.Show("Ya existe un barrio con el nombre ingresado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (barrioService.ModificarBarrio(NuevoBarrio(), oBarrio.IdBarrio))
                        MessageBox.Show("Barrio modificado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Error al modificar barrio", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

            this.DialogResult = DialogResult.OK;
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
