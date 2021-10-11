using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV.Negocio;
using TP_PAV.Entidades;

namespace TP_PAV.Interfaz.Consultas
{
    public partial class frmABMCliente : Form
    {
        public enum FormMode { nuevo, eliminar, modificar };
        private FormMode modo = FormMode.nuevo;
        private Cliente oCliente;
        private ClienteService clienteService;

        public frmABMCliente()
        {
            InitializeComponent();
        }

        public void IniciarFormulario(FormMode op, Cliente cliente = null)
        {
            modo = op;
            oCliente = cliente;
        }
    }
}
