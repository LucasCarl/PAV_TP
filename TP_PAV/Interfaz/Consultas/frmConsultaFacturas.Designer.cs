
namespace TP_PAV.Interfaz.Consultas
{
    partial class frmConsultaFacturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaFacturas));
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.nroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioCreador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.gbxFechaEmision = new System.Windows.Forms.GroupBox();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.nudNroFactura = new System.Windows.Forms.NumericUpDown();
            this.cbxUsuario = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblFilas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.gbxFechaEmision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroFactura,
            this.cliente,
            this.fechaAlta,
            this.monto,
            this.usuarioCreador});
            this.dgvFacturas.Location = new System.Drawing.Point(12, 138);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.RowHeadersWidth = 20;
            this.dgvFacturas.Size = new System.Drawing.Size(431, 172);
            this.dgvFacturas.TabIndex = 0;
            // 
            // nroFactura
            // 
            this.nroFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nroFactura.DataPropertyName = "numeroFactura";
            this.nroFactura.HeaderText = "Nº Factura";
            this.nroFactura.Name = "nroFactura";
            this.nroFactura.ReadOnly = true;
            this.nroFactura.Width = 77;
            // 
            // cliente
            // 
            this.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cliente.DataPropertyName = "cliente";
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Width = 64;
            // 
            // fechaAlta
            // 
            this.fechaAlta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechaAlta.DataPropertyName = "fechaAlta";
            this.fechaAlta.HeaderText = "Fecha Emisión";
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.ReadOnly = true;
            this.fechaAlta.Width = 93;
            // 
            // monto
            // 
            this.monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.monto.DataPropertyName = "monto";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.monto.DefaultCellStyle = dataGridViewCellStyle1;
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.Width = 62;
            // 
            // usuarioCreador
            // 
            this.usuarioCreador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.usuarioCreador.DataPropertyName = "usuarioCreador";
            this.usuarioCreador.HeaderText = "Usuario Creador";
            this.usuarioCreador.Name = "usuarioCreador";
            this.usuarioCreador.ReadOnly = true;
            this.usuarioCreador.Width = 99;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(185, 316);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // gbxFechaEmision
            // 
            this.gbxFechaEmision.Controls.Add(this.chkFecha);
            this.gbxFechaEmision.Controls.Add(this.lblFechaHasta);
            this.gbxFechaEmision.Controls.Add(this.dtpFechaHasta);
            this.gbxFechaEmision.Controls.Add(this.lblFechaDesde);
            this.gbxFechaEmision.Controls.Add(this.dtpFechaDesde);
            this.gbxFechaEmision.Location = new System.Drawing.Point(212, 12);
            this.gbxFechaEmision.Name = "gbxFechaEmision";
            this.gbxFechaEmision.Size = new System.Drawing.Size(190, 83);
            this.gbxFechaEmision.TabIndex = 37;
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
            this.lblFechaHasta.Location = new System.Drawing.Point(6, 51);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(35, 13);
            this.lblFechaHasta.TabIndex = 34;
            this.lblFechaHasta.Text = "Hasta";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Enabled = false;
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(53, 47);
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
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.Location = new System.Drawing.Point(12, 15);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(98, 13);
            this.lblNroFactura.TabIndex = 38;
            this.lblNroFactura.Text = "Número de Factura";
            // 
            // nudNroFactura
            // 
            this.nudNroFactura.Location = new System.Drawing.Point(116, 13);
            this.nudNroFactura.Name = "nudNroFactura";
            this.nudNroFactura.Size = new System.Drawing.Size(65, 20);
            this.nudNroFactura.TabIndex = 39;
            // 
            // cbxUsuario
            // 
            this.cbxUsuario.FormattingEnabled = true;
            this.cbxUsuario.Location = new System.Drawing.Point(60, 74);
            this.cbxUsuario.Name = "cbxUsuario";
            this.cbxUsuario.Size = new System.Drawing.Size(121, 21);
            this.cbxUsuario.TabIndex = 41;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 69);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(44, 26);
            this.lblUsuario.TabIndex = 40;
            this.lblUsuario.Text = "Usuario\r\nCreador";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(60, 44);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(121, 21);
            this.cbxCliente.TabIndex = 42;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 47);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 43;
            this.lblCliente.Text = "Cliente";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(12, 109);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 44;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblFilas
            // 
            this.lblFilas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilas.AutoSize = true;
            this.lblFilas.Location = new System.Drawing.Point(93, 119);
            this.lblFilas.Name = "lblFilas";
            this.lblFilas.Size = new System.Drawing.Size(121, 13);
            this.lblFilas.TabIndex = 45;
            this.lblFilas.Text = "Cantidad de resultados: ";
            this.lblFilas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmConsultaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(451, 347);
            this.Controls.Add(this.lblFilas);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.cbxUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.nudNroFactura);
            this.Controls.Add(this.lblNroFactura);
            this.Controls.Add(this.gbxFechaEmision);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dgvFacturas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(467, 386);
            this.MinimumSize = new System.Drawing.Size(467, 386);
            this.Name = "frmConsultaFacturas";
            this.Text = "Consulta de Facturas";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.gbxFechaEmision.ResumeLayout(false);
            this.gbxFechaEmision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.GroupBox gbxFechaEmision;
        private System.Windows.Forms.CheckBox chkFecha;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.NumericUpDown nudNroFactura;
        private System.Windows.Forms.ComboBox cbxUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioCreador;
        private System.Windows.Forms.Label lblFilas;
    }
}