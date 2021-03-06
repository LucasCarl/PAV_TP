using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV.Entidades
{
    public class Contacto
    {
        public int IdContacto { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string NombreCompleto { get { return Apellido + " " + Nombre; } }

        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }
    }
}
