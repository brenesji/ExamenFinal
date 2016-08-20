namespace SegundaParteExamen
{
    public class EntidadAlumno
    {
        public int id_estudiante;
        public string nombre;
        public string apellido;
        public string direccion;
        public int edad;
        public int id_curso;
        public int id_materia;
        public int id_profesor;


        public int Id_estudiante
        {
            get
            {
                return id_estudiante;
            }
            set
            {
                id_estudiante = value;
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

        public string Direccion
        {
            get
            {
                return direccion;
            }
            set
            {
                direccion = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }
        public int Id_curso
        {
            get
            {
                return id_curso;
            }
            set
            {
                id_curso = value;
            }
        }
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
        public int Id_profesor
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
        public EntidadAlumno()
        {
            id_estudiante = int.MinValue;
            nombre = string.Empty;
            apellido = string.Empty;
            direccion = string.Empty;
            edad = int.MinValue;
            id_curso = int.MinValue;
            id_materia = int.MinValue;
            id_profesor = int.MinValue;
        }


    }

}