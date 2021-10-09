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
        public int CicloPrueba { get; set; }    //Cambiar a entidad CiclioPrueba si hace falta
        public float Precio { get; set; }
    }
}
