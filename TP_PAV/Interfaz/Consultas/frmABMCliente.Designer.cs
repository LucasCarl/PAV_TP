
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
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.lblRazon = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnAccion = new System.Windows.Forms.Button();
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
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(65, 17);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(100, 20);
            this.txtCuit.TabIndex = 1;
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
            this.txtCalle.Location = new System.Drawing.Point(65, 87);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 20);
            this.txtCalle.TabIndex = 5;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(16, 90);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(30, 13);
            this.lblCalle.TabIndex = 4;
            this.lblCalle.Text = "Calle";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(65, 117);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 7;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(16, 120);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "Número";
            // 
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(154, 153);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(64, 20);
            this.btnAccion.TabIndex = 9;
            this.btnAccion.Text = "Accion";
            this.btnAccion.UseVisualStyleBackColor = true;
            // 
            // frmABMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 183);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.txtRazon);
            this.Controls.Add(this.lblRazon);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.lblCuit);
            this.Name = "frmABMCliente";
            this.Text = "frmABMCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.Label lblRazon;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnAccion;
    }
}