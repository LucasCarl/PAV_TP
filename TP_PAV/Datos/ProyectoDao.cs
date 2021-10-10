using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_PAV.Entidades;

namespace TP_PAV.Datos
{
    class ProyectoDao
    {
        private Proyecto MapeoProyecto(DataRow fila)
        {
            Proyecto proyecto = new Proyecto();
            proyecto.IdProyecto = Convert.ToInt32(fila["id_proyecto"].ToString());
            proyecto.Descripcion = fila["descripcion"].ToString();
            proyecto.Version = fila["version"].ToString();
            proyecto.Alcance = fila["alcance"].ToString();
            
            proyecto.Producto = new Producto();
            proyecto.Producto.IdProducto = Convert.ToInt32(fila["id_producto"].ToString());
            proyecto.Producto.Nombre = fila["Producto"].ToString();

            UsuarioDao usuDao = new UsuarioDao();
            proyecto.Responsable = new Usuario();
            proyecto.Responsable = usuDao.ObtenerUsuario(fila["usuario"].ToString());

            return proyecto;
        }

        public IList<Proyecto> ObtenerTodos()
        {
            List<Proyecto> listadoProyectos = new List<Proyecto>();

            //Consulta SQL
            string sqlComando = string.Concat("SELECT P.id_proyecto, P.id_producto, PR.nombre AS 'Producto', P.descripcion, P.alcance, P.version, U.usuario ",
                                              "FROM Proyectos P LEFT JOIN Productos PR ON P.id_producto = PR.id_producto ",
                                              "LEFT JOIN Usuarios U ON P.id_responsable = U.id_usuario ",
                                              "WHERE P.borrado = 0");
            var resultadoConsulta = DataManager.Instancia().ConsultaSQL(sqlComando).Rows;

            foreach (DataRow resultado in resultadoConsulta)
            {
                listadoProyectos.Add(MapeoProyecto(resultado));
            }

            return listadoProyectos;
        }

        public IList<Proyecto> ObtenerProyectoFiltro(Dictionary<string, object> parametros = null)
        {
            List<Proyecto> listadoProyectos = new List<Proyecto>();

            //Consulta SQL
            string sqlComando = string.Concat("SELECT P.id_proyecto, P.id_producto, PR.nombre AS 'Producto', P.descripcion, P.alcance, P.version, U.usuario ",
                                              "FROM Proyectos P LEFT JOIN Productos PR ON P.id_producto = PR.id_producto ",
                                              "LEFT JOIN Usuarios U ON P.id_responsable = U.id_usuario ",
                                              "WHERE P.borrado = 0");
            var resultadoConsulta = DataManager.Instancia().ConsultaSQL(sqlComando, parametros).Rows;

            foreach (DataRow resultado in resultadoConsulta)
            {
                listadoProyectos.Add(MapeoProyecto(resultado));
            }

            return listadoProyectos;
        }
    }
}
