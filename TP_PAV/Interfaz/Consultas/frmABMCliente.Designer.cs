
namespace TP_PAV.Interfaz.Consultas
{
    partial class frmABMCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMCliente));
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.lblRazon = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnAccion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxBarrio = new System.Windows.Forms.ComboBox();
            this.cbxContacto = new System.Windows.Forms.ComboBox();
            this.txtCuit = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMostrarCont = new System.Windows.Forms.Button();
            this.btnModifCont = new System.Windows.Forms.Button();
            this.btnNuevoCont = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(16, 20);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(32, 13);
            this.lblCuit.TabIndex = 0;
            this.lblCuit.Text = "CUIT";
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(65, 52);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(100, 20);
            this.txtRazon.TabIndex = 3;
            // 
            // lblRazon
            // 
            this.lblRazon.AutoSize = true;
            this.lblRazon.Location = new System.Drawing.Point(16, 50);
            this.lblRazon.Name = "lblRazon";
            this.lblRazon.Size = new System.Drawing.Size(38, 26);
            this.lblRazon.TabIndex = 2;
            this.lblRazon.Text = "Razon\r\nSocial";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(67, 86);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 20);
            this.txtCalle.TabIndex = 5;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(18, 89);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(30, 13);
            this.lblCalle.TabIndex = 4;
            this.lblCalle.Text = "Calle";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(67, 112);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 7;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(18, 115);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "Número";
            // 
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(156, 138);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(64, 20);
            this.btnAccion.TabIndex = 9;
            this.btnAccion.Text = "Accion";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Barrio";
            // 
            // cbxBarrio
            // 
            this.cbxBarrio.FormattingEnabled = true;
            this.cbxBarrio.Location = new System.Drawing.Point(226, 86);
            this.cbxBarrio.Name = "cbxBarrio";
            this.cbxBarrio.Size = new System.Drawing.Size(121, 21);
            this.cbxBarrio.TabIndex = 11;
            // 
            // cbxContacto
            // 
            this.cbxContacto.FormattingEnabled = true;
            this.cbxContacto.Location = new System.Drawing.Point(60, 0);
            this.cbxContacto.Name = "cbxContacto";
            this.cbxContacto.Size = new System.Drawing.Size(100, 21);
            this.cbxContacto.TabIndex = 13;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(65, 17);
            this.txtCuit.Mask = "00-00000000-0";
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(80, 20);
            this.txtCuit.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMostrarCont);
            this.groupBox1.Controls.Add(this.btnModifCont);
            this.groupBox1.Controls.Add(this.btnNuevoCont);
            this.groupBox1.Controls.Add(this.cbxContacto);
            this.groupBox1.Location = new System.Drawing.Point(182, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 60);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contacto";
            // 
            // btnMostrarCont
            // 
            this.btnMostrarCont.Location = new System.Drawing.Point(127, 31);
            this.btnMostrarCont.Name = "btnMostrarCont";
            this.btnMostrarCont.Size = new System.Drawing.Size(51, 23);
            this.btnMostrarCont.TabIndex = 16;
            this.btnMostrarCont.Text = "Mostrar";
            this.btnMostrarCont.UseVisualStyleBackColor = true;
            this.btnMostrarCont.Click += new System.EventHandler(this.btnMostrarCont_Click);
            // 
            // btnModifCont
            // 
            this.btnModifCont.Location = new System.Drawing.Point(60, 31);
            this.btnModifCont.Name = "btnModifCont";
            this.btnModifCont.Size = new System.Drawing.Size(61, 23);
            this.btnModifCont.TabIndex = 15;
            this.btnModifCont.Text = "Modificar";
            this.btnModifCont.UseVisualStyleBackColor = true;
            this.btnModifCont.Click += new System.EventHandler(this.btnModifCont_Click);
            // 
            // btnNuevoCont
            // 
            this.btnNuevoCont.Location = new System.Drawing.Point(7, 31);
            this.btnNuevoCont.Name = "btnNuevoCont";
            this.btnNuevoCont.Size = new System.Drawing.Size(47, 23);
            this.btnNuevoCont.TabIndex = 14;
            this.btnNuevoCont.Text = "Nuevo";
            this.btnNuevoCont.UseVisualStyleBackColor = true;
            this.btnNuevoCont.Click += new System.EventHandler(this.btnNuevoCont_Click);
            // 
            // frmABMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(378, 166);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.cbxBarrio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.txtRazon);
            this.Controls.Add(this.lblRazon);
            this.Controls.Add(this.lblCuit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 205);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(394, 205);
            this.Name = "frmABMCliente";
            this.Text = "frmABMCliente";
            this.Load += new System.EventHandler(this.frmABMCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.Label lblRazon;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxBarrio;
        private System.Windows.Forms.ComboBox cbxContacto;
        private System.Windows.Forms.MaskedTextBox txtCuit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMostrarCont;
        private System.Windows.Forms.Button btnModifCont;
        private System.Windows.Forms.Button btnNuevoCont;
    }
}