using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV.Entidades
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Cuit { get; set; }
        public string RazonSocial { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public Barrio Barrio { get; set; }
        public Contacto Contacto { get; set; }

        public string Direccion()
        {
            string dir = Calle + " " + Numero;
            return dir;
        }

        public override string ToString()
        {
            return RazonSocial;
        }
    }
}
