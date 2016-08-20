using System.Data;

namespace PrimeraParteExamen.Controlador
{
    public class ControladorMateria
    {
        Modelo.Modelo mod = new Modelo.Modelo();
        EntidadMateria entidad = new EntidadMateria();
        string sql;

        public DataTable leer()
        {
            sql = "SELECT "
                + "ID_MATERIA,"
                + "NOMBRE,"
                + "ID_PROFESOR"
                + " FROM "
                + "MATERIA";
            return mod.llenarDT(sql);
        }

        public DataTable buscar(int id)
        {
            sql = "SELECT "
                + "ID_MATERIA,"
                + "NOMBRE,"
                + "ID_PROFESOR"
                + " FROM "
                + "MATERIA"
                + " WHERE "
                + "ID_MATERIA = " + id;
            return mod.llenarDT(sql);
        }

        public void insertar(EntidadMateria entidad)
        {
            sql = "INSERT INTO MATERIA ("
                + "ID_MATERIA,"
                + "NOMBRE,"
                + "ID_PROFESOR"
                + ") VALUES ("
                + entidad.Id_materia + ","
                + "'" + entidad.Nombre + "',"
                + entidad.Id_Profesor
                //+ 1 //entidad.Id_Salario
                + ")";
            mod.ejecutarSQL(sql);
        }

        public void modificar(EntidadMateria entidad)
        {
            sql = "UPDATE MATERIA SET "
                + "NOMBRE ='" + entidad.Nombre + "',"
                + "ID_PROFESOR = " +entidad.Id_Profesor
                + " WHERE "
                + "ID_MATERIA = " + entidad.Id_materia;
            mod.ejecutarSQL(sql);
        }

        public void eliminar(int id)
        {
            sql = "DELETE MATERIA "
                + "WHERE "
                + "ID_MATERIA = " + id;
            mod.ejecutarSQL(sql);
        }
    }
}
