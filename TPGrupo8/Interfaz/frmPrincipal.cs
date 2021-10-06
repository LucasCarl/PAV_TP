using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TPGrupo8.Interfaz.Consultas;

namespace TPGrupo8.Interfaz
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void contactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContactos contactos = new frmContactos();
            contactos.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            lblUsuario.Text += login.usr;
        }
    }
}
