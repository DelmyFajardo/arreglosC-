using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    internal class Program
    {
        const char disponible = '-';
        char[,] tablero =
        {
            { disponible,disponible,disponible },
            { disponible,disponible,disponible },
            { disponible,disponible,disponible },
        };
        static void Main(string[] args)
        {
            Program p = new Program();
            bool fin = false;
            char jugadorActual = 'X';
            do
            {
                p.RealizarJugada(jugadorActual);
                p.MostrarTablero();
                fin = p.tableroLleno() || p.EsGanador(jugadorActual);
                jugadorActual = jugadorActual == 'X' ? '0' : 'X';
            } while (!fin);

            Console.ReadKey();
            Console.ReadLine();
        }
        private bool EsGanador(char jugadorActual)
        {

            for (int i = 0; i < 3; i++)
            {    
                if (tablero[i, 0] == jugadorActual && tablero[i, 1] == jugadorActual && tablero[i, 2] == jugadorActual)
                {
                    Console.WriteLine("Felicidades jugador " + jugadorActual + " Has Ganado!!!");
                    return true;
                }
          
                if (tablero[0, i] == jugadorActual && tablero[1, i] == jugadorActual && tablero[2, i] == jugadorActual)
                {
                    Console.WriteLine("Felicidades jugador " + jugadorActual + " Has Ganado!!!");
                    return true;
                }
               

                if (tablero[0, 0] == jugadorActual && tablero[1, 1] == jugadorActual && tablero[2, 2] == jugadorActual)
                {
                    Console.WriteLine("Felicidades jugador " + jugadorActual + " Has Ganado!!!");
                    return true;
                }
            }
            return false;

        }


        private bool tableroLleno()
        {
            bool esDisponible = true;
            for (int fi = 0; fi < 3; fi++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (tablero[fi, col] == disponible)
                    {
                        esDisponible = false;
                        return esDisponible;
                    }
                }
            }
            return esDisponible;
        }
        private void RealizarJugada(char jugadorActual)
        { 
            Console.WriteLine("Es el turno de" + jugadorActual);
            bool valida = false;
            do
            {
                Console.WriteLine("Elija una fija");
                int fila = int.Parse(Console.ReadLine());
                Console.WriteLine("elija una columna");
                int columna = int.Parse(Console.ReadLine());

                if (tablero[fila, columna] == disponible)
                {
                    tablero[fila, columna] = jugadorActual;
                    valida = true;
                }
                else
                {
                    Console.WriteLine("pocision invalida");
                    valida = false;
                }
                
            } while (!valida);

        }

        
        public void MostrarTablero()
        {  
            Console.Clear();
            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(tablero[fila, col]);
                }
                Console.WriteLine();

            }
            Console.WriteLine("Preciona una tecla");
            Console.ReadKey();
        }
    }
}

