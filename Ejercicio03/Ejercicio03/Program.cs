using System;
using Biblioteca;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudianteUno = new Estudiante("pepe","romero","101a");
            Estudiante estudianteDos = new Estudiante("martin", "jorel", "105b");
            Estudiante estudianteTres = new Estudiante("roberto", "ñeto", "151a");


            estudianteUno.SetNotaPrimerParcial(10);
            estudianteUno.SetNotaSegundoParcial(2);
            Console.WriteLine(estudianteUno.Mostrar());

            estudianteDos.SetNotaPrimerParcial(5);
            estudianteDos.SetNotaSegundoParcial(3);
            Console.WriteLine(estudianteDos.Mostrar());

            estudianteTres.SetNotaPrimerParcial(8);
            estudianteTres.SetNotaSegundoParcial(4);
            Console.WriteLine(estudianteTres.Mostrar());

            Console.ReadKey();
        }
    }
}
