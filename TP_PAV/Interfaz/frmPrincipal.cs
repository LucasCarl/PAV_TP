﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV.Interfaz.Consultas;

namespace TP_PAV.Interfaz
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            lblUsuario.Text += Program.usuarioActual.NombreUsuario;
        }

        private void contactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContactos contactos = new frmContactos();
            contactos.Show();
        }

        private void barrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBarrio barrio = new frmBarrio();
            barrio.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.Show();
        }

        private void proyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProyectos proyectos = new frmProyectos();
            proyectos.Show();
        }
    }
}
