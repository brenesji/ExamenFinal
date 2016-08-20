using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraParteExamen.Controlador
{
    public class EntidadMateria
    {
        private int id_materia;
        private string nombre;
        private int id_profesor;

        public int Id_materia
        {
            get
            {
                return id_materia;
            }
            set
            {
                id_materia = value;
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

        public EntidadMateria()
        {
            id_materia = int.MinValue;
            nombre = string.Empty;
            id_profesor = int.MinValue;
        }
    }
}
