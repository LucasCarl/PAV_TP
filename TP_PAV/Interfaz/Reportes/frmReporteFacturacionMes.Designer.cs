
namespace TP_PAV.Interfaz.Reportes
{
    partial class frmReporteFacturacionMes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteFacturacionMes));
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.rpvFacturacionMes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "MMMM yyyy";
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(104, 12);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.ShowUpDown = true;
            this.dtpDesde.Size = new System.Drawing.Size(108, 20);
            this.dtpDesde.TabIndex = 0;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(12, 14);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(86, 13);
            this.lblDesde.TabIndex = 1;
            this.lblDesde.Text = "Mes-Año Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(232, 14);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(83, 13);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Mes-Año Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.CustomFormat = "MMMM yyyy";
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(321, 12);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.ShowUpDown = true;
            this.dtpHasta.Size = new System.Drawing.Size(108, 20);
            this.dtpHasta.TabIndex = 2;
            // 
            // rpvFacturacionMes
            // 
            this.rpvFacturacionMes.LocalReport.ReportEmbeddedResource = "TP_PAV.Interfaz.Reportes.rptFacturacionMes.rdlc";
            this.rpvFacturacionMes.Location = new System.Drawing.Point(12, 38);
            this.rpvFacturacionMes.Name = "rpvFacturacionMes";
            this.rpvFacturacionMes.ServerReport.BearerToken = null;
            this.rpvFacturacionMes.Size = new System.Drawing.Size(776, 400);
            this.rpvFacturacionMes.TabIndex = 4;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(450, 9);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(84, 23);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmReporteFacturacionMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.rpvFacturacionMes);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpDesde);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteFacturacionMes";
            this.Text = "Facturación por Mes";
            this.Load += new System.EventHandler(this.frmReporteFacturacionMes_Load);
            this.ResizeBegin += new System.EventHandler(this.frmReporteFacturacionMes_ResizeBegin);
            this.Resize += new System.EventHandler(this.frmReporteFacturacionMes_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private Microsoft.Reporting.WinForms.ReportViewer rpvFacturacionMes;
        private System.Windows.Forms.Button btnConsultar;
    }
}