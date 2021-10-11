using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV.Entidades
{
    public class CiclioPrueba
    {
        public int IdCiclo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Usuario Responsable { get; set; }
        public PlanPrueba PlanPrueba { get; set; }
        public bool Aceptado { get; set; }
    }
}
