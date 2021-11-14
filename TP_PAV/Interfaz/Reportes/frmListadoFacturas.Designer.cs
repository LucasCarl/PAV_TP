
namespace TP_PAV.Interfaz.Reportes
{
    partial class frmListadoFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoFacturas));
            this.FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsListadofacturas = new TP_PAV.Interfaz.Reportes.dsListadoFacturas();
            this.rpvListadoFacturas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gbxFechaEmision = new System.Windows.Forms.GroupBox();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadofacturas)).BeginInit();
            this.gbxFiltros.SuspendLayout();
            this.gbxFechaEmision.SuspendLayout();
            this.SuspendLayout();
            // 
            // FacturaBindingSource
            // 
            this.FacturaBindingSource.DataMember = "Factura";
            this.FacturaBindingSource.DataSource = this.dsListadofacturas;
            // 
            // dsListadofacturas
            // 
            this.dsListadofacturas.DataSetName = "dsListadofacturas";
            this.dsListadofacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvListadoFacturas
            // 
            reportDataSource1.Name = "dsListadoFacturas";
            reportDataSource1.Value = this.FacturaBindingSource;
            this.rpvListadoFacturas.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvListadoFacturas.LocalReport.ReportEmbeddedResource = "TP_PAV.Interfaz.Reportes.rptListadoFacturas.rdlc";
            this.rpvListadoFacturas.Location = new System.Drawing.Point(12, 87);
            this.rpvListadoFacturas.Name = "rpvListadoFacturas";
            this.rpvListadoFacturas.ServerReport.BearerToken = null;
            this.rpvListadoFacturas.Size = new System.Drawing.Size(776, 352);
            this.rpvListadoFacturas.TabIndex = 0;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(20, 35);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente:";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(68, 32);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(126, 21);
            this.cbxCliente.TabIndex = 2;
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.btnConsultar);
            this.gbxFiltros.Controls.Add(this.gbxFechaEmision);
            this.gbxFiltros.Controls.Add(this.cbxCliente);
            this.gbxFiltros.Controls.Add(this.lblCliente);
            this.gbxFiltros.Location = new System.Drawing.Point(12, 12);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Size = new System.Drawing.Size(630, 69);
            this.gbxFiltros.TabIndex = 3;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Filtros";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(530, 39);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(92, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // gbxFechaEmision
            // 
            this.gbxFechaEmision.Controls.Add(this.chkFecha);
            this.gbxFechaEmision.Controls.Add(this.lblFechaHasta);
            this.gbxFechaEmision.Controls.Add(this.dtpFechaHasta);
            this.gbxFechaEmision.Controls.Add(this.lblFechaDesde);
            this.gbxFechaEmision.Controls.Add(this.dtpFechaDesde);
            this.gbxFechaEmision.Location = new System.Drawing.Point(200, 16);
            this.gbxFechaEmision.Name = "gbxFechaEmision";
            this.gbxFechaEmision.Size = new System.Drawing.Size(324, 47);
            this.gbxFechaEmision.TabIndex = 38;
            this.gbxFechaEmision.TabStop = false;
            this.gbxFechaEmision.Text = "Fecha Emisión";
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Location = new System.Drawing.Point(85, 0);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(15, 14);
            this.chkFecha.TabIndex = 36;
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Enabled = false;
            this.lblFechaHasta.Location = new System.Drawing.Point(168, 23);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(35, 13);
            this.lblFechaHasta.TabIndex = 34;
            this.lblFechaHasta.Text = "Hasta";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Enabled = false;
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(215, 19);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaHasta.TabIndex = 35;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Enabled = false;
            this.lblFechaDesde.Location = new System.Drawing.Point(6, 23);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(38, 13);
            this.lblFechaDesde.TabIndex = 30;
            this.lblFechaDesde.Text = "Desde";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Enabled = false;
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(53, 19);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaDesde.TabIndex = 33;
            // 
            // frmListadoFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.gbxFiltros);
            this.Controls.Add(this.rpvListadoFacturas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(670, 39);
            this.Name = "frmListadoFacturas";
            this.Text = "frmListadoFacturas";
            this.Load += new System.EventHandler(this.frmListadoFacturas_Load);
            this.ResizeBegin += new System.EventHandler(this.frmListadoFacturas_ResizeBegin);
            this.Resize += new System.EventHandler(this.frmListadoFacturas_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadofacturas)).EndInit();
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            this.gbxFechaEmision.ResumeLayout(false);
            this.gbxFechaEmision.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvListadoFacturas;
        private System.Windows.Forms.BindingSource FacturaBindingSource;
        private dsListadoFacturas dsListadofacturas;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.GroupBox gbxFechaEmision;
        private System.Windows.Forms.CheckBox chkFecha;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Button btnConsultar;
    }
}