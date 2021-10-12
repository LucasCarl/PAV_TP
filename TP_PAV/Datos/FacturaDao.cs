using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV.Entidades;

namespace TP_PAV.Datos
{
    class FacturaDao
    {
        public int UltimaFactura()
        {
            string sqlComand = "SELECT TOP 1 numero_factura FROM Facturas WHERE borrado = 0 ORDER BY numero_factura DESC";

            var resultadoConsulta = DataManager.Instancia().ConsultaSQL(sqlComand);
            if (resultadoConsulta.Rows.Count == 1)
                return Convert.ToInt32(resultadoConsulta.Rows[0]);
            else
                return 1;
        }
    }
}
