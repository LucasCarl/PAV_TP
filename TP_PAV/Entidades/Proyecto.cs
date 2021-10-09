using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV.Entidades
{
    public class Proyecto
    {
        public int IdProyecto { get; set; }
        public Producto Producto { get; set; }
        public string Descripcion { get; set; }
        public string Version { get; set; }
        public string Alcance { get; set; }
        public Usuario Responsable { get; set; }
    }
}
