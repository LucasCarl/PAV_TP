using System;
using System.Collections.Generic;
using System.Text;

namespace TPGrupo8.Entidades
{
    public class Perfil
    {
        public int IdPerfil { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
