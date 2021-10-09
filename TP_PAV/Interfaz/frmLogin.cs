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

namespace TP_PAV.Interfaz
{
    public partial class frmLogin : Form
    {
        public string usr;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Validar que se haya ingresado un usuario
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Se debe ingresar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Validar que se haya ingresado una password
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Se debe ingresar una contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Valida el usuario
            //Por ahora el validarusuario da un bool, despues lo podemos cambiar para que devuelva un usuario
            UsuarioService usuService = new UsuarioService();
            if (usuService.ValidarUsuario(txtUsuario.Text, txtPassword.Text))
            {
                usr = txtUsuario.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña invalidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
