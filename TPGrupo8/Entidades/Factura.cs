using System;
using System.Collections.Generic;
using System.Text;

namespace TPGrupo8.Entidades
{
    class Factura
    {
        public int IdFactura { get; set; }
        public string NumeroFactura { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaAlta { get; set; }
        public Usuario UsuarioCreador { get; set; }
    }
}
