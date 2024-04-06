using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            List<string> Dolist = new List<string>();
            string contador ;
           
            do
            {
                Console.WriteLine("Elija un opcion");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Mostrar");
                Console.WriteLine("3. Eliminar");
                Console.WriteLine("4. Salir");
                contador = Console.ReadLine();

                switch (contador)
                {
                    case "1":
                        agregar(Dolist);
                      
                        break;
                    case "2":
                        
                        mostrar(Dolist);
                        break;
                    case "3":
                       
                        eliminar(Dolist);
                        break;
                    case "4":
                        Console.WriteLine("que tengas lindo dia");
                        break;
                    default:
                        Console.WriteLine("opcion invalida");
                        break;

                }
            } while (contador != "4");
        }

        static void mostrar(List<string>Dolist)
        {
            Console.WriteLine("Acontinuacion se te muestran las tareas actuales");
            
                Console.WriteLine(Dolist);
            
        }

        static  void agregar(List<string> Dolist)
        {
            Console.WriteLine("Ingrese la tarea a agregar: ");
            string tarea = Console.ReadLine(); 
            Dolist.Add(tarea);
        }

        static void eliminar (List<string> Dolist)
        {
            Console.WriteLine("Ingrese el numero de tarea a eliminar:");
            int numeroTarea = int.Parse (Console.ReadLine());
           if (numeroTarea >= 1 && numeroTarea <=Dolist.Count) 
            {
                Dolist.RemoveAt(numeroTarea - 1);

            }
        }
    }


}
