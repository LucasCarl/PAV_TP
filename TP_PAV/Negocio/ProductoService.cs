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
        public IList<Producto> ListaProductos()
        {
            var resultadoConsulta = DataManager.Instancia().ConsultaSQL("SELECT * FROM Productos WHERE borrado = 0").Rows;

            List<Producto> listadoProductos = new List<Producto>();
            foreach (DataRow fila in resultadoConsulta)
            {
                listadoProductos.Add(MapeoProducto(fila));
            }

            return listadoProductos;
        }

        public Producto ObtenerProducto(int id)
        {
            var resultado = DataManager.Instancia().ConsultaSQL("SELECT id_producto, nombre FROM Productos WHERE id_producto = " + id);

            return MapeoProducto(resultado.Rows[0]);
        }

        private Producto MapeoProducto(DataRow fila)
        {
            Producto producto = new Producto();
            producto.IdProducto = Convert.ToInt32(fila["id_producto"].ToString());
            producto.Nombre = fila["nombre"].ToString();

            return producto;
        }
    }
}
