using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV.Entidades
{
    public class DetalleFactura
    {
        public int IdDetalleFactura { get; set; }
        public int NumeroOrden { get; set; }
        public Producto Producto { get; set; }
        public Proyecto Proyecto { get; set; }
        //public CiclioPrueba CicloPrueba { get; set; }
        public float Precio { get; set; }
    }
}
