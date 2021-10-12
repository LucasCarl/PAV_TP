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

namespace TP_PAV.Interfaz
{
    public partial class frmFactura : Form
    {
        private Factura factura;

        private FacturaService facturaService = new FacturaService();
        private ClienteService clienteService = new ClienteService();
        private ProductoService productoService = new ProductoService();
        private ProyectoService proyectoService = new ProyectoService();

        private Cliente clienteSeleccionado = new Cliente();

        public frmFactura()
        {
            InitializeComponent();
        }

        private void LlenarCombobox(ComboBox cbx, object source, string mostrar, string valor)
        {
            cbx.DataSource = source;        //Origen de datos
            cbx.DisplayMember = mostrar;    //Propiedad a mostrar
            cbx.ValueMember = valor;        //Ruta de acceso a propiedad
            cbx.SelectedIndex = -1;         //Indice para que no este elegido nada
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            //this.dgvDetalles.AllowUserToAddRows = false;
            //Carga Fecha y NumFactura
            factura = new Factura();
            factura.NumeroFactura = (facturaService.UltimaFactura() + 1).ToString();
            factura.FechaAlta = DateTime.Today;

            txtFecha.Text = factura.FechaAlta.ToShortDateString();
            txtNumero.Text = factura.NumeroFactura;

            //Llena comboboxes
            LlenarCombobox(cbxCliente, clienteService.ObtenerClientes(), "razonSocial", "idCliente");
            LlenarCombobox(cbxProducto, productoService.ListaProductos(), "nombre", "id_producto");
            LlenarCombobox(cbxProyecto, proyectoService.ObtenerProyectos(), "descripcion", "idProyecto");

            //Añade el evento de Mostrar datos del cliente
            this.cbxCliente.SelectedValueChanged += new System.EventHandler(this.cbxCliente_SelectedValueChanged);

            factura.ListadoDetalles = new List<DetalleFactura>();
        }

        private void rdbProyecto_CheckedChanged(object sender, EventArgs e)
        {
            cbxProyecto.Enabled = rdbProyecto.Checked;
            cbxProyecto.SelectedIndex = -1;
        }

        private void rdbProducto_CheckedChanged(object sender, EventArgs e)
        {
            cbxProducto.Enabled = rdbProducto.Checked;
            cbxProducto.SelectedIndex = -1;
        }

        private void cbxCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbxCliente.SelectedIndex > -1)
            {
                clienteSeleccionado = (Cliente)cbxCliente.SelectedItem;
                txtCuit.Text = clienteSeleccionado.Cuit;
                txtRazon.Text = clienteSeleccionado.RazonSocial;
                txtDireccion.Text = clienteSeleccionado.Calle + " " + clienteSeleccionado.Numero;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DetalleFactura detalle = new DetalleFactura();
            detalle.NumeroOrden = factura.ListadoDetalles.Count + 1;

            //Producto o Proyecto
            if (rdbProducto.Checked)
            {
                if (cbxProducto.SelectedIndex >= 0)
                    detalle.Producto = productoService.ObtenerProducto(Convert.ToInt32(cbxProducto.SelectedValue));
                else
                {
                    MessageBox.Show("Seleccione un producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else if (rdbProyecto.Checked)
            {
                if (cbxProyecto.SelectedIndex >= 0)
                    detalle.Proyecto = (Proyecto)cbxProyecto.SelectedItem;
                else
                {
                    MessageBox.Show("Seleccione un proyecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto o proyecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Checkea Precio
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Debe ingresar un precio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
                detalle.Precio = Convert.ToInt32(txtPrecio.Text);

            factura.ListadoDetalles.Add(detalle);

            MostrarDetalles();
            ActualizarTotal();
            LimpiarCampos();

        }

        private void ActualizarTotal()
        {
            float total = 0;
            foreach (DetalleFactura detalle in factura.ListadoDetalles)
            {
                total += detalle.Precio;
            }

            txtTotal.Text = total.ToString();
        }

        private void LimpiarCampos()
        {
            rdbProducto.Checked = false;
            rdbProyecto.Checked = false;
            txtPrecio.Text = "";
        }

        private void MostrarDetalles()
        {
            dgvDetalles.DataSource = null;
            dgvDetalles.DataSource = factura.ListadoDetalles;
            dgvDetalles.Update();
            /*
            for (int i = 0; i < dgvDetalles.RowCount; i++)
            {
                dgvDetalles.Rows[i].Cells["NroOrden"].Value = factura.ListadoDetalles[i].NumeroOrden;
                dgvDetalles.Rows[i].Cells["Precio"].Value = factura.ListadoDetalles[i].Precio;

                if (factura.ListadoDetalles[i].Producto != null)
                {
                    dgvDetalles.Rows[i].Cells["Tipo"].Value = "Producto";
                    dgvDetalles.Rows[i].Cells["Descripcion"].Value = factura.ListadoDetalles[i].Producto.ToString();
                }
                else
                {
                    dgvDetalles.Rows[i].Cells["Tipo"].Value = "Proyecto";
                    dgvDetalles.Rows[i].Cells["Descripcion"].Value = factura.ListadoDetalles[i].Proyecto.MostrarDescripcion();
                }
            }
            */
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //Controlar que haya cliente
            if (cbxCliente.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //Controlar que haya al menos 1 detalle
            if (factura.ListadoDetalles.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un producto o proyecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Agrega datos faltantes a factura(cliente y usuario)
            factura.Cliente = clienteSeleccionado;
            factura.UsuarioCreador = Program.usuarioActual;

            if (facturaService.CargarFactura(factura))
                MessageBox.Show("Factura generada con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error al generar factura", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
