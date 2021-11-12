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

namespace TP_PAV.Interfaz.Reportes
{
    public partial class frmReporteFacturacionMes : Form
    {
        private Size sizeVentanaViejo;
        private Size sizeReportViejo;

        public frmReporteFacturacionMes()
        {
            InitializeComponent();
        }

        private void frmReporteFacturacionMes_Load(object sender, EventArgs e)
        {
            //Setea el dia de los datatimepicker al primero para evitar error si es dia 31
            DateTime fecha = DateTime.Today;
            dtpDesde.Value = new DateTime(fecha.Year, fecha.Month, 1);
            dtpHasta.Value = new DateTime(fecha.Year, fecha.Month, 1);
        }

        #region Cambiar size report si cambia size ventana
        private void frmReporteFacturacionMes_ResizeBegin(object sender, EventArgs e)
        {
            sizeVentanaViejo = this.Size;
            sizeReportViejo = rpvFacturacionMes.Size;
        }

        private void frmReporteFacturacionMes_Resize(object sender, EventArgs e)
        {
            int x = this.Size.Width - sizeVentanaViejo.Width;
            int y = this.Size.Height - sizeVentanaViejo.Height;

            rpvFacturacionMes.Size = new Size(sizeReportViejo.Width + x, sizeReportViejo.Height + y);

        }

        #endregion

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Toma fechas
            DateTime fechaDesde = dtpDesde.Value.Date;
            DateTime fechaHasta = dtpHasta.Value.Date;
            
            //Control de fechas
            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("La fecha desde no debe ser mayor a la fecha hasta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((fechaHasta - fechaDesde).TotalDays > 365)
            {
                MessageBox.Show("El periodo debe ser menor a un año.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Crear datatable
            DataTable tablaMes = new DataTable();
            tablaMes.Columns.Add("Mes");
            tablaMes.Columns.Add("Total");
            tablaMes.Columns.Add("Fecha");

            int mesesDif = fechaHasta.Month - fechaDesde.Month;

            //Carga fechas
            label1.Text = fechaDesde.ToString();

            int diasMes = DateTime.DaysInMonth(fechaHasta.Year, fechaHasta.Month);
            fechaHasta = new DateTime(fechaHasta.Year, fechaHasta.Month, diasMes);
            label1.Text += " --> " + fechaHasta.ToShortDateString() + " -Dif " + mesesDif;
        }
    }
}
