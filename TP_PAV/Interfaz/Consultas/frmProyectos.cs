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
    public partial class frmProyectos : Form
    {
        ProyectoService proyectoService = new ProyectoService();
        public frmProyectos()
        {
            InitializeComponent();
        }

        private void frmProyectos_Load(object sender, EventArgs e)
        {
            ProductoService productoService = new ProductoService();
            UsuarioService usuarioService = new UsuarioService();

            //Llenar ComboBox
            LlenarCombobox(cbxProductos, productoService.ListaProductos(), "nombre", "id_producto");
            LlenarCombobox(cbxResponsable, usuarioService.ListaUsuarios(), "usuario", "id_usuario");
        }

        private void LlenarCombobox(ComboBox cbx, object source, string mostrar, string valor)
        {
            cbx.DataSource = source;        //Origen de datos
            cbx.DisplayMember = mostrar;    //Propiedad a mostrar
            cbx.ValueMember = valor;        //Ruta de acceso a propiedad
            cbx.SelectedIndex = -1;         //Indice para que no este elegido nada
        }

        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnBorrar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            IList<Proyecto> lista;
            //Comprueba filtros
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            if (!string.IsNullOrEmpty(cbxProductos.Text))
                parametros.Add("idProducto", cbxProductos.SelectedValue);
            if (!string.IsNullOrEmpty(txtDescripcion.Text))
                parametros.Add("descripcion", txtDescripcion.Text);
            if (!string.IsNullOrEmpty(txtVersion.Text))
                parametros.Add("version", txtVersion.Text);
            if (!string.IsNullOrEmpty(txtAlcance.Text))
                parametros.Add("alcance", txtAlcance.Text);
            if (!string.IsNullOrEmpty(cbxResponsable.Text))
                parametros.Add("responsable", cbxResponsable.Text);

            lista = proyectoService.ObtenerProyectos(parametros);

            dgvTabla.DataSource = lista;
            //Resetea botones borrar/editar
            btnBorrar.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMProyecto abmProyecto = new frmABMProyecto();
            abmProyecto.IniciarFormulario(frmABMProyecto.FormMode.nuevo);
            abmProyecto.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmABMProyecto abmProyecto = new frmABMProyecto();
            abmProyecto.IniciarFormulario(frmABMProyecto.FormMode.modificar, (Proyecto)dgvTabla.CurrentRow.DataBoundItem);
            abmProyecto.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            frmABMProyecto abmProyecto = new frmABMProyecto();
            abmProyecto.IniciarFormulario(frmABMProyecto.FormMode.eliminar, (Proyecto)dgvTabla.CurrentRow.DataBoundItem);
            abmProyecto.ShowDialog();
            btnConsultar_Click(sender, e);
        }
    }
}
