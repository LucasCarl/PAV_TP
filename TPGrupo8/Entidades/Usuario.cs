using System;
using System.Collections.Generic;
using System.Text;

namespace TPGrupo8.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public Perfil Perfil { get; set; }


        public override string ToString()
        {
            return NombreUsuario;
        }
    }
}
