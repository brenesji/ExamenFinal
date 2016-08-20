using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraParteExamen.Controlador
{
    public class EntidadProfesor
    {
        private int id_profesor;
        private string nombre;
        private string apellido;


        public int Id_Profesor
        {
            get
            {
                return id_profesor;
            }
            set
            {
                id_profesor = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }


        public EntidadProfesor()
        {
            id_profesor = int.MinValue;
            nombre = string.Empty;
            apellido = string.Empty;
        }
    }
}
