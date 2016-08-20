using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SegundaParteExamen
{
    class Program
    {
        //Estadisticas esta = new Estadisticas();
        static Estadisticas esta = new Estadisticas();
        static int option = 0;


        public static void Main(string[] args)
        {

            do
            {
                Console.Clear();
                Console.WriteLine("-* Librería el Buen Lector  *-*");
                Console.WriteLine("1. Generar.");
                Console.WriteLine("2. Mostrar.");
                Console.WriteLine("3. Imprimir.");
                Console.WriteLine("4. Salir.");
                Console.WriteLine("Selecciones una opción");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            esta.generar();
                            break;
                        }
                    case 2:
                        {
                            //Modificar la información
                            esta.mostrar();
                            break;
                        }
                    case 3:
                        {
                            //Eliminar información dejando campos en 0 o vacío
                            esta.imprimir();
                            break;
                        }

                    case 4:
                        //Salir
                        break;
                    default:
                        {
                            Console.WriteLine("Seleccione inválida..");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            } while (option != 4);

        }

            
    }
}
