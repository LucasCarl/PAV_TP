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
    public partial class frmABMCliente : Form
    {
        public enum FormMode { nuevo, eliminar, modificar, mostrar };
        private FormMode modo = FormMode.nuevo;
        private Cliente oCliente;
        private ClienteService clienteService = new ClienteService();
        private BarrioService barrioService = new BarrioService();
        private ContactoService contactoService = new ContactoService();

        public frmABMCliente()
        {
            InitializeComponent();
        }

        public void IniciarFormulario(FormMode op, Cliente cliente = null)
        {
            modo = op;
            oCliente = cliente;
        }

        private void LlenarCombobox(ComboBox cbx, object source, string mostrar, string valor)
        {
            cbx.DataSource = source;        //Origen de datos
            cbx.DisplayMember = mostrar;    //Propiedad a mostrar
            cbx.ValueMember = valor;        //Ruta de acceso a propiedad
            cbx.SelectedIndex = -1;         //Indice para que no este elegido nada
        }

        private void frmABMCliente_Load(object sender, EventArgs e)
        {
            //Llenar ComboBoxes
            LlenarCombobox(cbxBarrio, barrioService.ObtenerBarrios(), "nombre", "idBarrio");
            LlenarCombobox(cbxContacto, contactoService.ObtenerContactos(), "apellido", "idContacto");

            //Cambiar dependiendo del modo
            switch (modo)
            {
                case FormMode.nuevo:
                    this.Text = "Nuevo Cliente";
                    btnAccion.Text = "Añadir";
                    break;

                case FormMode.eliminar:
                    this.Text = "Eliminar Cliente";
                    btnAccion.Text = "Eliminar";
                    MostrarDatos();
                    txtCuit.Enabled = false;
                    txtRazon.Enabled = false;
                    txtCalle.Enabled = false;
                    txtNumero.Enabled = false;
                    cbxBarrio.Enabled = false;
                    cbxContacto.Enabled = false;
                    break;

                case FormMode.modificar:
                    this.Text = "Modificar Cliente";
                    btnAccion.Text = "Modificar";
                    MostrarDatos();
                    break;

                case FormMode.mostrar:
                    this.Text = "Datos Cliente";
                    btnAccion.Text = "Cerrar";
                    MostrarDatos();
                    txtCuit.Enabled = false;
                    txtRazon.Enabled = false;
                    txtCalle.Enabled = false;
                    txtNumero.Enabled = false;
                    cbxBarrio.Enabled = false;
                    cbxContacto.Enabled = false;
                    break;
            }
        }

        private void MostrarDatos()
        {
            if(oCliente != null)
            {
                txtCuit.Text = oCliente.Cuit;
                txtRazon.Text = oCliente.RazonSocial;
                txtCalle.Text = oCliente.Calle;
                txtNumero.Text = oCliente.Numero;
                cbxBarrio.SelectedValue = oCliente.Barrio.IdBarrio;
                cbxContacto.SelectedValue = oCliente.Contacto.IdContacto;
            }
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            //Control de vacio
            if (ControlVacio())
            {
                MessageBox.Show("Debe llenar todos los campos antes de continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (modo)
            {
                case FormMode.nuevo:
                    if (clienteService.ExisteCliente(txtCuit.Text))
                    {
                        MessageBox.Show("Ya existe un cliente con el CUIT ingresado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (clienteService.NuevoCliente(CargarCliente()))
                        MessageBox.Show("Cliente creado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Error al crear cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case FormMode.eliminar:
                    if (MessageBox.Show("Seguro desea eliminar el cliente?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (clienteService.EliminarCliente(oCliente))
                            MessageBox.Show("Cliente eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Error al eliminar cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case FormMode.modificar:
                    if (clienteService.ExisteCliente(txtCuit.Text))
                    {
                        MessageBox.Show("Ya existe un cliente con el CUIT ingresado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (clienteService.ModificarCliente(CargarCliente(), oCliente.IdCliente))
                        MessageBox.Show("Cliente modificado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Error al modificar cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case FormMode.mostrar:
                    this.Close();
                    break;
            }

            this.Close();
        }

        private bool ControlVacio()
        {
            bool vacio = false;

            if (string.IsNullOrEmpty(txtCuit.Text))
            {
                txtCuit.BackColor = Color.FromArgb(255, 120, 120);
                vacio = true;
            }
            else
                txtCuit.BackColor = Color.FromKnownColor(KnownColor.Window);

            if (string.IsNullOrEmpty(txtRazon.Text))
            {
                txtRazon.BackColor = Color.FromArgb(255, 120, 120);
                vacio = true;
            }
            else
                txtRazon.BackColor = Color.FromKnownColor(KnownColor.Window);

            if (string.IsNullOrEmpty(txtCalle.Text))
            {
                txtCalle.BackColor = Color.FromArgb(255, 120, 120);
                vacio = true;
            }
            else
                txtCalle.BackColor = Color.FromKnownColor(KnownColor.Window);

            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                txtNumero.BackColor = Color.FromArgb(255, 120, 120);
                vacio = true;
            }
            else
                txtNumero.BackColor = Color.FromKnownColor(KnownColor.Window);

            return vacio;
        }

        private Cliente CargarCliente()
        {
            Cliente newCliente = new Cliente();
            newCliente.Cuit = txtCuit.Text;
            newCliente.RazonSocial = txtRazon.Text;
            newCliente.Calle = txtCalle.Text;
            newCliente.Numero = txtNumero.Text;
            newCliente.Barrio = barrioService.TomarBarrio(Convert.ToInt32(cbxBarrio.SelectedValue));
            newCliente.Contacto = contactoService.TomarContacto(Convert.ToInt32(cbxContacto.SelectedValue));

            return newCliente;
        }
    }
}
