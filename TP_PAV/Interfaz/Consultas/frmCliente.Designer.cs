
namespace TP_PAV.Interfaz.Consultas
{
    partial class frmCliente
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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.lblRazon = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.cbxBarrio = new System.Windows.Forms.ComboBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.gbxFechaAlta = new System.Windows.Forms.GroupBox();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.gbxFechaAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Location = new System.Drawing.Point(150, 365);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(64, 20);
            this.btnBorrar.TabIndex = 21;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(81, 365);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(64, 20);
            this.btnEditar.TabIndex = 20;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(11, 365);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(64, 20);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(12, 186);
            this.dgvTabla.MultiSelect = false;
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowTemplate.Height = 25;
            this.dgvTabla.Size = new System.Drawing.Size(389, 174);
            this.dgvTabla.TabIndex = 18;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(12, 160);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(64, 20);
            this.btnConsultar.TabIndex = 17;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(11, 22);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(32, 13);
            this.lblCuit.TabIndex = 22;
            this.lblCuit.Text = "CUIT";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(81, 19);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(100, 20);
            this.txtCuit.TabIndex = 23;
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(81, 45);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(100, 20);
            this.txtRazon.TabIndex = 25;
            // 
            // lblRazon
            // 
            this.lblRazon.AutoSize = true;
            this.lblRazon.Location = new System.Drawing.Point(11, 48);
            this.lblRazon.Name = "lblRazon";
            this.lblRazon.Size = new System.Drawing.Size(70, 13);
            this.lblRazon.TabIndex = 24;
            this.lblRazon.Text = "Razon Social";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(274, 19);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 20);
            this.txtCalle.TabIndex = 27;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(224, 22);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(30, 13);
            this.lblCalle.TabIndex = 26;
            this.lblCalle.Text = "Calle";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(274, 45);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 29;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(224, 48);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 28;
            this.lblNumero.Text = "Número";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(6, 25);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(38, 13);
            this.lblFechaDesde.TabIndex = 30;
            this.lblFechaDesde.Text = "Desde";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(224, 74);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(34, 13);
            this.lblBarrio.TabIndex = 31;
            this.lblBarrio.Text = "Barrio";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(12, 74);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(50, 13);
            this.lblContacto.TabIndex = 32;
            this.lblContacto.Text = "Contacto";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(53, 19);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaDesde.TabIndex = 33;
            // 
            // cbxBarrio
            // 
            this.cbxBarrio.FormattingEnabled = true;
            this.cbxBarrio.Location = new System.Drawing.Point(274, 74);
            this.cbxBarrio.Name = "cbxBarrio";
            this.cbxBarrio.Size = new System.Drawing.Size(100, 21);
            this.cbxBarrio.TabIndex = 34;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(82, 74);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(100, 20);
            this.txtContacto.TabIndex = 35;
            // 
            // gbxFechaAlta
            // 
            this.gbxFechaAlta.Controls.Add(this.lblFechaHasta);
            this.gbxFechaAlta.Controls.Add(this.dtpFechaHasta);
            this.gbxFechaAlta.Controls.Add(this.lblFechaDesde);
            this.gbxFechaAlta.Controls.Add(this.dtpFechaDesde);
            this.gbxFechaAlta.Location = new System.Drawing.Point(15, 101);
            this.gbxFechaAlta.Name = "gbxFechaAlta";
            this.gbxFechaAlta.Size = new System.Drawing.Size(359, 53);
            this.gbxFechaAlta.TabIndex = 36;
            this.gbxFechaAlta.TabStop = false;
            this.gbxFechaAlta.Text = "Fecha Alta";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(165, 24);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(35, 13);
            this.lblFechaHasta.TabIndex = 34;
            this.lblFechaHasta.Text = "Hasta";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(212, 18);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaHasta.TabIndex = 35;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 397);
            this.Controls.Add(this.gbxFechaAlta);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.cbxBarrio);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.txtRazon);
            this.Controls.Add(this.lblRazon);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.btnConsultar);
            this.Name = "frmCliente";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.gbxFechaAlta.ResumeLayout(false);
            this.gbxFechaAlta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.Label lblRazon;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.ComboBox cbxBarrio;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.GroupBox gbxFechaAlta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
    }
}