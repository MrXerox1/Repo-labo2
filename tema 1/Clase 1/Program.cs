using System;

namespace Clase_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Beep();

            string palabra;
            int longitudPalabra;
            int longitud;

            do
            {
                Console.WriteLine("Escribe una longitud");

            } while (!int.TryParse(Console.ReadLine(), out longitud));
            

            Console.WriteLine("Escribe una palabra");
            palabra = Console.ReadLine();

            longitudPalabra = palabra.Length;

            if (longitudPalabra > longitud)
            {
                Console.WriteLine("la longitud de tu palabra '{0}' es mayor a {1}", palabra,longitud);
            }
            else if (longitudPalabra == longitud)
            {
                Console.WriteLine("la longitud de tu palabra '{0}' es igual a {1}", palabra, longitud);
            }
            else
            {
                Console.WriteLine("la longitud de tu palabra '{0}' es menor a {1}", palabra, longitud);
            }
            Console.ReadKey();

        }
    }
}
