using System.Data;

namespace PrimeraParteExamen.Controlador
{
    public class ControladorProfesor
    {
        Modelo.Modelo mod = new Modelo.Modelo();
        EntidadProfesor entidad = new EntidadProfesor();
        string sql;

        public DataTable leer()
        {
            sql = "SELECT "
                + "ID_PROFESOR,"
                + "NOMBRE,"
                + "APELLIDO"
                + " FROM "
                + "PROFESOR";
            return mod.llenarDT(sql);
        }

        public DataTable buscar(int id)
        {
            sql = "SELECT "
                + "ID_PROFESOR,"
                + "NOMBRE,"
                + "APELLIDO"
                + " FROM "
                + "PROFESOR"
                + " WHERE "
                + "ID_PROFESOR = " + id;
            return mod.llenarDT(sql);
        }

        public void insertar(EntidadProfesor entidad)
        {
            sql = "INSERT INTO PROFESOR ("
                + "ID_PROFESOR,"
                + "NOMBRE,"
                + "APELLIDO"
                + ") VALUES ("
                + entidad.Id_Profesor + ","
                + "'" + entidad.Nombre + "',"
                + "'" + entidad.Apellido + "'"
                //+ 1 //entidad.Id_Salario
                + ")";
            mod.ejecutarSQL(sql);
        }

        public void modificar(EntidadProfesor entidad)
        {
            sql = "UPDATE PROFESOR SET "
                + "NOMBRE ='" + entidad.Nombre + "',"
                + "APELLIDO ='" + entidad.Apellido + "'"
                + " WHERE "
                + "ID_PROFESOR = " + entidad.Id_Profesor;
            mod.ejecutarSQL(sql);
        }

        public void eliminar(int id)
        {
            sql = "DELETE PROFESOR "
                + "WHERE "
                + "ID_PROFESOR = " + id;
            mod.ejecutarSQL(sql);
        }
    }
}
