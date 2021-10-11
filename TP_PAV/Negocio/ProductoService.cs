using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_PAV.Datos;
using TP_PAV.Entidades;

namespace TP_PAV.Negocio
{
    class ProductoService
    {
        public DataTable ListaProductos()
        {
            return DataManager.Instancia().ConsultaSQL("SELECT * FROM Productos WHERE borrado = 0");
        }

        public Producto ObtenerProducto(int id)
        {
            var resultado = DataManager.Instancia().ConsultaSQL("SELECT id_producto, nombre FROM Productos WHERE id_producto = " + id);

            Producto producto = new Producto();
            producto.IdProducto = Convert.ToInt32(resultado.Rows[0]["id_producto"].ToString());
            producto.Nombre = resultado.Rows[0]["nombre"].ToString();

            return producto;
        }
    }
}
