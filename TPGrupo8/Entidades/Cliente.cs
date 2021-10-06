using System;
using System.Collections.Generic;
using System.Text;

namespace TPGrupo8.Entidades
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
    }
}
