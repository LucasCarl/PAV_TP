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
        private ProductoService productoService;
        private UsuarioService usuarioService;

        public frmABMProyecto()
        {
            InitializeComponent();
            proyectoService = new ProyectoService();
            productoService = new ProductoService();
            usuarioService = new UsuarioService();
        }

        public void IniciarFormulario(FormMode op, Proyecto proyecto = null)
        {
            modo = op;
            oProyecto = proyecto;
        }

        private void LlenarCombobox(ComboBox cbx, object source, string mostrar, string valor)
        {
            cbx.DataSource = source;        //Origen de datos
            cbx.DisplayMember = mostrar;    //Propiedad a mostrar
            cbx.ValueMember = valor;        //Ruta de acceso a propiedad
            cbx.SelectedIndex = -1;         //Indice para que no este elegido nada
        }

        private void frmABMProyecto_Load(object sender, EventArgs e)
        {
            //Llenar ComboBox de Productos
            LlenarCombobox(cbxProductos, productoService.ListaProductos(), "nombre", "id_producto");
            LlenarCombobox(cbxResponsable, usuarioService.ListaUsuarios(), "usuario", "id_usuario");

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
                    cbxResponsable.Enabled = false;
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
                cbxProductos.SelectedValue = oProyecto.Producto.IdProducto;
                txtDescripcion.Text = oProyecto.Descripcion;
                txtVersion.Text = oProyecto.Version;
                txtAlcance.Text = oProyecto.Alcance;
                cbxResponsable.SelectedValue = oProyecto.Responsable.IdUsuario;
            }
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            //Control de vacio
            if(ControlVacio())
            {
                MessageBox.Show("Debe llenar todos los campos antes de continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (modo)
            {
                case FormMode.nuevo:
                    if(proyectoService.NuevoProyecto(CargarProyecto()))
                        MessageBox.Show("Proyecto creado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Error al crear proyecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case FormMode.eliminar:
                    if(MessageBox.Show("Seguro desea eliminar el proyecto?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if(proyectoService.EliminarProyecto(oProyecto))
                            MessageBox.Show("Proyecto eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Error al eliminar proyecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case FormMode.modificar:
                    if(proyectoService.ModificarProyecto(CargarProyecto(), oProyecto.IdProyecto))
                        MessageBox.Show("Proyecto Modificado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Error al modificar proyecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            this.Close();
        }

        private bool ControlVacio()
        {
            bool vacio = false;

            //Control de combobox

            if(string.IsNullOrEmpty(txtAlcance.Text))
            {
                txtAlcance.BackColor = Color.FromArgb(255, 120, 120);
                vacio = true;
            }
            else
                txtAlcance.BackColor = Color.FromKnownColor(KnownColor.Window);

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                txtDescripcion.BackColor = Color.FromArgb(255, 120, 120);
                vacio = true;
            }
            else
                txtDescripcion.BackColor = Color.FromKnownColor(KnownColor.Window);

            if (string.IsNullOrEmpty(txtVersion.Text))
            {
                txtVersion.BackColor = Color.FromArgb(255, 120, 120);
                vacio = true;
            }
            else
                txtVersion.BackColor = Color.FromKnownColor(KnownColor.Window);

            return vacio;
        }

        private Proyecto CargarProyecto()
        {
            Proyecto newProyecto = new Proyecto();
            newProyecto.Producto = productoService.ObtenerProducto(Convert.ToInt32(cbxProductos.SelectedValue));
            newProyecto.Descripcion = txtDescripcion.Text;
            newProyecto.Alcance = txtAlcance.Text;
            newProyecto.Version = txtVersion.Text;
            newProyecto.Responsable = usuarioService.ObtenerUsuario(Convert.ToInt32(cbxResponsable.SelectedValue));

            return newProyecto;
        }
    }
}
