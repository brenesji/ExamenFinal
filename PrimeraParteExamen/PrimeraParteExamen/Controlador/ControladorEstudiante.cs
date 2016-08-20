using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace PrimeraParteExamen.Controlador
{
    public class ControladorEstudiante
    {
        Modelo.Modelo mod = new Modelo.Modelo();
        EntidadEstudiante entidad = new EntidadEstudiante();
        string sql;

        public DataTable leer()
        {
            sql = "SELECT "
                + "ID_ESTUDIANTE,"
                + "NOMBRE,"
                + "APELLIDO,"
                + "DIRECCION,"
                + "EDAD,"
                + "ID_CURSO"
                + " FROM "
                + "ESTUDIANTE";
            return mod.llenarDT(sql);
        }

        public DataTable buscar(int id)
        {
            sql = "SELECT "
                + "ID_ESTUDIANTE,"
                + "NOMBRE,"
                + "APELLIDO,"
                + "DIRECCION,"
                + "EDAD,"
                + "ID_CURSO"
                + " FROM "
                + "ESTUDIANTE"
                + " WHERE "
                + "ID_ESTUDIANTE = " + id;
            return mod.llenarDT(sql);
        }

        public void insertar(EntidadEstudiante entidad)
        {
            sql = "INSERT INTO ESTUDIANTE ("
                + "ID_ESTUDIANTE,"
                + "NOMBRE,"
                + "APELLIDO,"
                + "DIRECCION,"
                + "EDAD,"
                + "ID_CURSO"
                + ") VALUES ("
                + entidad.Id_estudiante + ","
                + "'" + entidad.Nombre + "',"
                + "'" + entidad.Apellido + "',"
                + "'" + entidad.Direccion + "',"
                + entidad.Edad + ","
                + entidad.Id_Curso 
                + ")";
            mod.ejecutarSQL(sql);
        }

        public void modificar(EntidadEstudiante entidad)
        {
            sql = "UPDATE ESTUDIANTE SET "
                + "NOMBRE ='" + entidad.Nombre + "',"
                + "APELLIDO = '" + entidad.Apellido + "',"
                + "DIRECCION = '" + entidad.Direccion + "',"
                + "EDAD = " + entidad.Edad + ","//entidad.Id_Salario
                + "ID_CURSO = " + entidad.Id_Curso
                + " WHERE "
                + "ID_ESTUDIANTE = " + entidad.Id_estudiante;
            mod.ejecutarSQL(sql);
        }

        public void eliminar(int id)
        {
            sql = "DELETE ESTUDIANTE "
                + "WHERE "
                + "ID_ESTUDIANTE = " + id;
            mod.ejecutarSQL(sql);
        }
    }
}
