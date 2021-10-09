
namespace TP_PAV.Interfaz.Consultas
{
    partial class frmProyectos
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtAlcance = new System.Windows.Forms.TextBox();
            this.lblAlcance = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cbxProductos = new System.Windows.Forms.ComboBox();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Location = new System.Drawing.Point(150, 317);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(64, 20);
            this.btnBorrar.TabIndex = 26;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(81, 317);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(64, 20);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(11, 317);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(64, 20);
            this.btnNuevo.TabIndex = 24;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(12, 138);
            this.dgvTabla.MultiSelect = false;
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowTemplate.Height = 25;
            this.dgvTabla.Size = new System.Drawing.Size(389, 174);
            this.dgvTabla.TabIndex = 23;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(12, 112);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(64, 20);
            this.btnConsultar.TabIndex = 22;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 47);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 27;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(81, 44);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 28;
            // 
            // txtAlcance
            // 
            this.txtAlcance.Location = new System.Drawing.Point(81, 70);
            this.txtAlcance.Name = "txtAlcance";
            this.txtAlcance.Size = new System.Drawing.Size(100, 20);
            this.txtAlcance.TabIndex = 30;
            // 
            // lblAlcance
            // 
            this.lblAlcance.AutoSize = true;
            this.lblAlcance.Location = new System.Drawing.Point(15, 73);
            this.lblAlcance.Name = "lblAlcance";
            this.lblAlcance.Size = new System.Drawing.Size(46, 13);
            this.lblAlcance.TabIndex = 29;
            this.lblAlcance.Text = "Alcance";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(15, 21);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 31;
            this.lblProducto.Text = "Producto";
            // 
            // cbxProductos
            // 
            this.cbxProductos.FormattingEnabled = true;
            this.cbxProductos.Location = new System.Drawing.Point(81, 17);
            this.cbxProductos.Name = "cbxProductos";
            this.cbxProductos.Size = new System.Drawing.Size(121, 21);
            this.cbxProductos.TabIndex = 32;
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(283, 79);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(100, 20);
            this.txtResponsable.TabIndex = 36;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(208, 73);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(69, 26);
            this.lblResponsable.TabIndex = 35;
            this.lblResponsable.Text = "Usuario\r\nResponsable";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(274, 44);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(100, 20);
            this.txtVersion.TabIndex = 34;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(208, 47);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 33;
            this.lblVersion.Text = "Version";
            // 
            // frmProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 344);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.cbxProductos);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.txtAlcance);
            this.Controls.Add(this.lblAlcance);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.btnConsultar);
            this.Name = "frmProyectos";
            this.Text = "frmProyectos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtAlcance;
        private System.Windows.Forms.Label lblAlcance;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cbxProductos;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label lblVersion;
    }
}