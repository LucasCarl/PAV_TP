using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV.Entidades
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public string NumeroFactura { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaAlta { get; set; }
        public Usuario UsuarioCreador { get; set; }
    }
}
