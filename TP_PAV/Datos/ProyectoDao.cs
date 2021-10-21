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
        UsuarioDao usuDao = new UsuarioDao();

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
                                              "WHERE P.borrado = 0 ");
            if (parametros.ContainsKey("idProducto"))
                sqlComando += " AND P.id_producto = @idProducto ";
            if (parametros.ContainsKey("descripcion"))
                sqlComando += " AND p.descripcion LIKE '%' + @descripcion + '%' ";
            if (parametros.ContainsKey("alcance"))
                sqlComando += " AND p.alcance LIKE '%' + @alcance + '%' ";
            if (parametros.ContainsKey("version"))
                sqlComando += " AND p.version LIKE '%' + @version + '%' ";
            if (parametros.ContainsKey("responsable"))
            {
                Usuario responsable = usuDao.ObtenerUsuario((string)parametros["responsable"]);
                int i;
                if (responsable != null)
                    i = responsable.IdUsuario;
                else
                    i = -1;
                sqlComando += " AND p.id_responsable = " + i;
            }
            var resultadoConsulta = DataManager.Instancia().ConsultaSQL(sqlComando, parametros).Rows;

            foreach (DataRow resultado in resultadoConsulta)
            {
                listadoProyectos.Add(MapeoProyecto(resultado));
            }

            return listadoProyectos;
        }

        public bool NuevoProyecto(Proyecto proyectoNuevo)
        {
            string sqlComando = string.Concat("INSERT INTO Proyectos (id_producto, descripcion, alcance, version, id_responsable, borrado) ",
                                                "VALUES (@idProducto, @descripcion, @alcance, @version, @idResponsable, 0)");

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("idProducto", proyectoNuevo.Producto.IdProducto);
            parametros.Add("descripcion", proyectoNuevo.Descripcion);
            parametros.Add("alcance", proyectoNuevo.Alcance);
            parametros.Add("version", proyectoNuevo.Version);
            parametros.Add("idResponsable", proyectoNuevo.Responsable.IdUsuario);

            return (DataManager.Instancia().EjecutarSQL(sqlComando, parametros) == 1);
        }

        public bool ModificarProyecto(Proyecto proyectoModif, int id)
        {
            string sqlComando = string.Concat("UPDATE Proyectos SET id_producto = @idProducto, descripcion = @descripcion, alcance = @alcance, ",
                                              "version = @version, id_responsable = @idResponsable WHERE id_proyecto = @idProyecto");

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("idProyecto", id);
            parametros.Add("idProducto", proyectoModif.Producto.IdProducto);
            parametros.Add("descripcion", proyectoModif.Descripcion);
            parametros.Add("alcance", proyectoModif.Alcance);
            parametros.Add("version", proyectoModif.Version);
            parametros.Add("idResponsable", proyectoModif.Responsable.IdUsuario);

            return (DataManager.Instancia().EjecutarSQL(sqlComando, parametros) == 1);
        }

        public bool EliminarProyecto(Proyecto proyectoBorrar)
        {
            string sqlComando = "UPDATE Proyectos SET borrado = 1 WHERE id_proyecto = @idProyecto";

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("idProyecto", proyectoBorrar.IdProyecto);

            return (DataManager.Instancia().EjecutarSQL(sqlComando, parametros) == 1);
        }

        public bool ExisteProyecto(int producto, string descripcion)
        {
            string sqlComando = "SELECT descripcion FROM Proyectos WHERE borrado = 0 AND id_producto = '" + producto + "' AND descripcion = '" + descripcion + "'";
            int resultadoConsulta = DataManager.Instancia().ConsultaSQL(sqlComando).Rows.Count;
            return resultadoConsulta > 0;
        }
    }
}
