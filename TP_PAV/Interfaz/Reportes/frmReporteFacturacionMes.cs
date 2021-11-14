using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TP_PAV.Negocio;
using TP_PAV.Entidades;

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
            dtpHasta.Value = new DateTime(fecha.Year, fecha.Month, 2);
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
            if (CalcularMesesDiferencia(fechaDesde, fechaHasta) == 0)
            {
                MessageBox.Show("El periodo debe tener al menos un mes de diferencia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((DateTime.Today.Month - fechaHasta.Month) < 0)
            {
                MessageBox.Show("El periodo no puede superar el mes actual.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Crear datatable
            DataTable tablaMes = new DataTable();
            tablaMes.Columns.Add("Mes", typeof(string));
            tablaMes.Columns.Add("Total", typeof(float));
            tablaMes.Columns.Add("Fecha", typeof(DateTime));

            int filasTabla = CalcularMesesDiferencia(fechaDesde, fechaHasta) + 1;
            for (int i = 0; i < filasTabla; i++)
            {
                DataRow fila = tablaMes.NewRow();
                DateTime fechaFila = fechaDesde.AddMonths(i);
                fila["Fecha"] = fechaFila;
                fila["Mes"] = String.Format("{0:MMM yyyy}", fechaFila);
                fila["Total"] = 0;
                tablaMes.Rows.Add(fila);
            }

            //Coloca fecha hasta en el ultimo dia del mes
            int diasMes = DateTime.DaysInMonth(fechaHasta.Year, fechaHasta.Month);
            fechaHasta = new DateTime(fechaHasta.Year, fechaHasta.Month, diasMes);

            //Cargar facturas
            FacturaService facturaService = new FacturaService();
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("fechaDesde", fechaDesde);
            parametros.Add("fechaHasta", fechaHasta);
            IList<Factura> listadoFacturas = facturaService.ObtenerFacturas(parametros);
            foreach (Factura factura in listadoFacturas)
            {
                int filaIndex = CalcularMesesDiferencia(fechaDesde, factura.FechaAlta);
                DataRow fila = tablaMes.Rows[filaIndex];
                float total = (float)fila["Total"] + factura.Monto;
                fila["Total"] = total;
            }

            //Refrescar Reporte
            ReportParameter fechaDesdeParametro = new ReportParameter("prFechaDesde", String.Format("{0:MMMM yyyy}", fechaDesde));
            ReportParameter fechaHastaParametro = new ReportParameter("prFechaHasta", String.Format("{0:MMMM yyyy}", fechaHasta));
            rpvFacturacionMes.LocalReport.SetParameters(new ReportParameter[] { fechaDesdeParametro, fechaHastaParametro });
            rpvFacturacionMes.LocalReport.DataSources.Clear();
            rpvFacturacionMes.LocalReport.DataSources.Add(new ReportDataSource("dsFacturasMes", tablaMes));
            rpvFacturacionMes.RefreshReport();
        }

        private int CalcularMesesDiferencia(DateTime fechaInicio, DateTime fechaFinal)
        {
            int mesesDif = fechaFinal.Month - fechaInicio.Month;
            if (fechaFinal.Year != fechaInicio.Year)
                mesesDif += 12;
            return mesesDif;
        }
    }
}
