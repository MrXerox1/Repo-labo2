using System;

namespace Prestamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta(500,  "roberto");
            Cuenta cuenta2 = new Cuenta(2500, "Martin");

            Console.WriteLine(cuenta1.Mostrar());
            Console.WriteLine(cuenta2.Mostrar());

            Console.WriteLine("--------------------------------------------------");

            cuenta1.Ingresar(400);
            cuenta2.Retirar(800);
            Console.WriteLine(cuenta1.Mostrar());
            Console.WriteLine(cuenta2.Mostrar());

            Console.WriteLine("--------------------------------------------------");

            cuenta1.Ingresar(-400);
            cuenta2.Retirar(2100);
            Console.WriteLine(cuenta1.Mostrar());
            Console.WriteLine(cuenta2.Mostrar());

            Console.ReadKey();
        }
    }
}
