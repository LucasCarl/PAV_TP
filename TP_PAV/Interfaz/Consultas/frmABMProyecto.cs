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
using TP_PAV.Datos;

namespace TP_PAV.Interfaz.Consultas
{
    public partial class frmABMProyecto : Form
    {
        public enum FormMode { nuevo, eliminar, modificar };
        private FormMode modo = FormMode.nuevo;
        private ProyectoService proyectoService;
        private Proyecto oProyecto;

        public frmABMProyecto()
        {
            InitializeComponent();
            proyectoService = new ProyectoService();
        }

        public void IniciarFormulario(FormMode op, Proyecto proyecto = null)
        {
            modo = op;
            oProyecto = proyecto;
        }

        private void frmABMProyecto_Load(object sender, EventArgs e)
        {
            //Llenar ComboBox de Productos
            cbxProductos.DataSource = DataManager.Instancia().ConsultaSQL("SELECT * FROM Productos WHERE borrado = 0");
            cbxProductos.DisplayMember = "nombre";
            cbxProductos.ValueMember = "id_producto";
            cbxProductos.SelectedItem = null;

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
                    cbxProductos.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtVersion.Enabled = false;
                    txtAlcance.Enabled = false;
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
            if(oProyecto != null)
            {
                cbxProductos.SelectedIndex = oProyecto.Producto.IdProducto;
                txtDescripcion.Text = oProyecto.Descripcion;
                txtVersion.Text = oProyecto.Version;
                txtAlcance.Text = oProyecto.Alcance;
            }
        }
    }
}
