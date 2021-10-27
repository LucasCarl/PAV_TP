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
    public partial class frmGenerarFactura : Form
    {
        private Factura factura;

        private FacturaService facturaService = new FacturaService();
        private ClienteService clienteService = new ClienteService();
        private ProductoService productoService = new ProductoService();
        private ProyectoService proyectoService = new ProyectoService();

        private Cliente clienteSeleccionado = new Cliente();

        private IList<Producto> listaProductos;
        private IList<Producto> listadoProductosDisponibles;
        private IList<Proyecto> listaProyectos;
        private IList<Proyecto> listadoProyectosDisponibles;

        public frmGenerarFactura()
        {
            InitializeComponent();
        }

        private void LlenarCombobox(ComboBox cbx, object source, string mostrar, string valor)
        {
            cbx.DataSource = null;
            cbx.DataSource = source;        //Origen de datos
            cbx.DisplayMember = mostrar;    //Propiedad a mostrar
            cbx.ValueMember = valor;        //Ruta de acceso a propiedad
            cbx.SelectedIndex = -1;         //Indice para que no este elegido nada
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            //this.dgvDetalles.AllowUserToAddRows = false;
            //Carga NumFactura
            factura = new Factura();
            factura.NumeroFactura = (facturaService.UltimaFactura() + 1).ToString();

            dtpFecha.Value = DateTime.Today;
            txtNumero.Text = factura.NumeroFactura;

            //Genera listas de productos y proyectos
            listaProductos = productoService.ListaProductos();
            listadoProductosDisponibles = new List<Producto>(listaProductos);
            listaProyectos = proyectoService.ObtenerProyectos();
            listadoProyectosDisponibles = new List<Proyecto>(listaProyectos);

            //Llena comboboxes
            LlenarCombobox(cbxCliente, clienteService.ObtenerClientes(), "razonSocial", "idCliente");
            LlenarCombobox(cbxProducto, listaProductos, "nombre", "idProducto");
            LlenarCombobox(cbxProyecto, listadoProyectosDisponibles, "descripcion", "idProyecto");

            //Añade el evento de Mostrar datos del cliente
            this.cbxCliente.SelectedValueChanged += new EventHandler(this.cbxCliente_SelectedValueChanged);

            factura.ListadoDetalles = new List<DetalleFactura>();
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

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            factura.FechaAlta = dtpFecha.Value;
        }

        #region Funciones Detalles
        ///Radio Buttons cuando cambian
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
        ///Habilita boton sacar
        private void dgvDetalles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSacar.Enabled = true;
        }

        ///Click en boton agregar detalle
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DetalleFactura detalle = new DetalleFactura();
            detalle.NumeroOrden = factura.ListadoDetalles.Count + 1;

            //Producto o Proyecto
            if (rdbProducto.Checked)
            {
                if (cbxProducto.SelectedIndex >= 0)
                {
                    detalle.Producto = (Producto)cbxProducto.SelectedItem;
                    listadoProductosDisponibles.Remove(detalle.Producto);
                }
                else
                {
                    MessageBox.Show("Seleccione un producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else if (rdbProyecto.Checked)
            {
                if (cbxProyecto.SelectedIndex >= 0)
                {
                    detalle.Proyecto = (Proyecto)cbxProyecto.SelectedItem;
                    listadoProyectosDisponibles.Remove(detalle.Proyecto);
                }
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
            if (nudPrecio.Value <= 0)
            {
                MessageBox.Show("Debe ingresar un precio mayor a 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
                detalle.Precio = (float)nudPrecio.Value;

            factura.ListadoDetalles.Add(detalle);

            ActualizarDetalles();
        }
        ///Click en boton sacar detalle
        private void btnSacar_Click(object sender, EventArgs e)
        {
            DetalleFactura detalleBorrar = (DetalleFactura)dgvDetalles.CurrentRow.DataBoundItem;
            //Agregar de vuelta producto/proyecto a cbx

            if(detalleBorrar.Producto != null)
            {
                int i = listaProductos.IndexOf(detalleBorrar.Producto);
                if (i < listadoProductosDisponibles.Count)
                    listadoProductosDisponibles.Insert(i, listaProductos[i]); 
                else
                    listadoProductosDisponibles.Add(listaProductos[i]);
            }
            else
            {
                int i = listaProyectos.IndexOf(detalleBorrar.Proyecto);
                if (i < listadoProyectosDisponibles.Count)
                    listadoProyectosDisponibles.Insert(i, listaProyectos[i]);
                else
                    listadoProyectosDisponibles.Add(listaProyectos[i]);

            }
            factura.ListadoDetalles.Remove(detalleBorrar);

            ActualizarDetalles();
        }

        ///Muestra detalles y el precio total
        private void ActualizarDetalles()
        {
            //Muestra los detalles en la tabla
            btnSacar.Enabled = false;
            dgvDetalles.DataSource = null;
            dgvDetalles.DataSource = factura.ListadoDetalles;
            dgvDetalles.Update();

            //Calcula el total
            float total = 0;
            foreach (DetalleFactura detalle in factura.ListadoDetalles)
            {
                total += detalle.Precio;
            }

            txtTotal.Text = total.ToString();

            //Actualiza comboboxes producto/proyecto
            LlenarCombobox(cbxProducto, listadoProductosDisponibles, "nombre", "idProducto");
            LlenarCombobox(cbxProyecto, listadoProyectosDisponibles, "descripcion", "idProyecto");

            //Limpia Comboboxes y precio
            rdbProducto.Checked = false;
            rdbProyecto.Checked = false;
            nudPrecio.Value = 0;
        }
        #endregion

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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (cbxCliente.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Consultas.frmABMCliente frmCliente = new Consultas.frmABMCliente();
            frmCliente.IniciarFormulario(Consultas.frmABMCliente.FormMode.mostrar, (Cliente)cbxCliente.SelectedItem);
            frmCliente.ShowDialog();
        }
    }
}
