using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TPGrupo8.Negocio;
using TPGrupo8.Entidades;

namespace TPGrupo8.Interfaz.Consultas
{
    public partial class frmBarrio : Form
    {
        BarrioService barrioService = new BarrioService();
        public frmBarrio()
        {
            InitializeComponent();
        }

        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnBorrar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            IList<Barrio> lista;
            //Comprueba si hay que tomar filtros o no
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            if (!String.IsNullOrEmpty(txtNombre.Text))
                parametros.Add("nombre", txtNombre.Text);

            lista = barrioService.ObtenerBarrios(parametros);

            dgvTabla.DataSource = lista;

            //Resetea botones borrar/editar
            btnBorrar.Enabled = false;
            btnEditar.Enabled = false;
        }
    }
}
