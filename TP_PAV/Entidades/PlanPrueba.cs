using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV.Entidades
{
    public class PlanPrueba
    {
        public int IdPlan { get; set; }
        public Proyecto Proyecto { get; set; }
        public string Nombre { get; set; }
        public Usuario Responsable { get; set; }
        public string Descripcion { get; set; }
    }
}
