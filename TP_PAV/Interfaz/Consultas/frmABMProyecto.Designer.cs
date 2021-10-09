
namespace TP_PAV.Interfaz.Consultas
{
    partial class frmABMProyecto
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
            this.btnAccion = new System.Windows.Forms.Button();
            this.txtAlcance = new System.Windows.Forms.TextBox();
            this.lblAlcance = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cbxProductos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(182, 177);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(64, 20);
            this.btnAccion.TabIndex = 9;
            this.btnAccion.Text = "Accion";
            this.btnAccion.UseVisualStyleBackColor = true;
            // 
            // txtAlcance
            // 
            this.txtAlcance.Location = new System.Drawing.Point(76, 139);
            this.txtAlcance.MaxLength = 50;
            this.txtAlcance.Name = "txtAlcance";
            this.txtAlcance.Size = new System.Drawing.Size(103, 20);
            this.txtAlcance.TabIndex = 17;
            // 
            // lblAlcance
            // 
            this.lblAlcance.AutoSize = true;
            this.lblAlcance.Location = new System.Drawing.Point(16, 142);
            this.lblAlcance.Name = "lblAlcance";
            this.lblAlcance.Size = new System.Drawing.Size(46, 13);
            this.lblAlcance.TabIndex = 16;
            this.lblAlcance.Text = "Alcance";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(76, 99);
            this.txtVersion.MaxLength = 50;
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(68, 20);
            this.txtVersion.TabIndex = 15;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(16, 102);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 14;
            this.lblVersion.Text = "Versión";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(76, 59);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(103, 20);
            this.txtDescripcion.TabIndex = 13;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(16, 62);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(16, 20);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(55, 13);
            this.lblProducto.TabIndex = 10;
            this.lblProducto.Text = "Productos";
            // 
            // cbxProductos
            // 
            this.cbxProductos.FormattingEnabled = true;
            this.cbxProductos.Location = new System.Drawing.Point(76, 17);
            this.cbxProductos.Name = "cbxProductos";
            this.cbxProductos.Size = new System.Drawing.Size(121, 21);
            this.cbxProductos.TabIndex = 18;
            // 
            // frmABMProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 209);
            this.Controls.Add(this.cbxProductos);
            this.Controls.Add(this.txtAlcance);
            this.Controls.Add(this.lblAlcance);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.btnAccion);
            this.Name = "frmABMProyecto";
            this.Text = "frmABMProyecto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.TextBox txtAlcance;
        private System.Windows.Forms.Label lblAlcance;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cbxProductos;
    }
}