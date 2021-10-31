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
using TP_PAV.Interfaz.Reportes;
using TP_PAV.Entidades;

namespace TP_PAV.Interfaz.Consultas
{
    public partial class frmConsultaFacturas : Form
    {
        private FacturaService facturaService = new FacturaService();

        public frmConsultaFacturas()
        {
            InitializeComponent();
        }

        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnImprimir.Enabled = true;
            }
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            dgvFacturas.DataSource = facturaService.ObtenerFacturas();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Factura factura = (Factura)dgvFacturas.CurrentRow.DataBoundItem;
            frmReporteFactura frmReporteFactura = new frmReporteFactura(factura);
            frmReporteFactura.ShowDialog();
        }
    }
}
