using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV.Datos;
using TP_PAV.Entidades;

namespace TP_PAV.Negocio
{
    class FacturaService
    {
        private FacturaDao facturaDao = new FacturaDao();

        public int UltimaFactura()
        {
            return facturaDao.UltimaFactura();
        }

        public bool CargarFactura(Factura factura)
        {
            return facturaDao.CargarFactura(factura);
        }
    }
}
