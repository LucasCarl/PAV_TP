
namespace TP_PAV.Interfaz.Reportes
{
    partial class frmReporteFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsFacturas = new TP_PAV.Interfaz.Reportes.dsFacturas();
            this.DetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvFactura
            // 
            this.rpvFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DetallesBindingSource;
            this.rpvFactura.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvFactura.LocalReport.ReportEmbeddedResource = "TP_PAV.Interfaz.Reportes.rptFactura.rdlc";
            this.rpvFactura.Location = new System.Drawing.Point(0, 0);
            this.rpvFactura.Name = "rpvFactura";
            this.rpvFactura.ServerReport.BearerToken = null;
            this.rpvFactura.Size = new System.Drawing.Size(800, 450);
            this.rpvFactura.TabIndex = 0;
            // 
            // dsFacturas
            // 
            this.dsFacturas.DataSetName = "dsFacturas";
            this.dsFacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DetallesBindingSource
            // 
            this.DetallesBindingSource.DataMember = "Detalles";
            this.DetallesBindingSource.DataSource = this.dsFacturas;
            // 
            // frmReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvFactura);
            this.Name = "frmReporteFactura";
            this.Text = "frmReporteFactura";
            this.Load += new System.EventHandler(this.frmReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvFactura;
        private System.Windows.Forms.BindingSource DetallesBindingSource;
        private dsFacturas dsFacturas;
    }
}