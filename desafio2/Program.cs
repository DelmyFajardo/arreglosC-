using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            
                int[,] productos = new int[5, 5];
                int[] totalCompras = new int[5];

                Console.WriteLine("Ingresa la cantidad que gasto cada usuario en sus comparas para obtener un descuento");

                for (int filas = 0; filas < 5; filas++)
                {
                    for (int columnas = 0; columnas < 5; columnas++)
                    {
                        Console.Write("Ingrese el monto de las compras para el cliente {0}: ", filas + 1);
                        productos[filas, columnas] = Convert.ToInt32(Console.ReadLine());
                    }
                }


                Console.WriteLine();
                Console.WriteLine("Montos de compras por cliente: ");
                for (int filas = 0; filas < 5; filas++)
                {
                    int totalCliente = 0;
                    for (int columnas = 0; columnas < 5; columnas++)
                    {
                        Console.Write("{0}\t", productos[filas, columnas]);
                        totalCliente += productos[filas, columnas];
                    }
                    totalCompras[filas] = totalCliente;
                    Console.WriteLine("La suma total de las compras de los cliente {0}: {1}", filas + 1, totalCliente);
                }


                Console.WriteLine();
                Console.WriteLine("Descuento por cada cliente: ");
                for (int fila = 0; fila < 5; fila++)
                {
                    decimal descuento = 0;
                    if (totalCompras[fila] >= 100 && totalCompras[fila] <= 1000)
                    {
                        descuento = 0.1m;
                    }
                    else if (totalCompras[fila] > 1000)
                    {
                        descuento = 0.2m;
                    }
                    Console.WriteLine("Cliente {0}: {1}%", fila + 1, descuento * 100);
                }

                Console.ReadKey();
            
        }
    }
}
