using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV.Interfaz.Consultas;
using TP_PAV.Interfaz.Reportes;

namespace TP_PAV.Interfaz
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text += Program.usuarioActual.NombreUsuario;
        }

        private void contactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContactos contactos = new frmContactos();
            contactos.Show();
        }

        private void barrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBarrio barrio = new frmBarrio();
            barrio.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.Show();
        }

        private void proyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProyectos proyectos = new frmProyectos();
            proyectos.Show();
        }

        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenerarFactura factura = new frmGenerarFactura();
            factura.ShowDialog();
        }

        private void consultarFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaFacturas consultaFacturas = new frmConsultaFacturas();
            consultaFacturas.ShowDialog();
        }

        private void tsmFacturacionMes_Click(object sender, EventArgs e)
        {
            frmReporteFacturacionMes facturacionMes = new frmReporteFacturacionMes();
            facturacionMes.ShowDialog();
        }

        private void listadoDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoFacturas listadoFacturas = new frmListadoFacturas();
            listadoFacturas.ShowDialog();
        }

        private void acercaDelProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema para la gestión de facturas: Permite generar facturas y generar reportes respecto a ellas.\nVersion Alpha 1.0", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
