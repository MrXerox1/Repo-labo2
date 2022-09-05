using System;

namespace Calcauladora
{
    internal class Program
    {
        public static bool validarNumero(string a, out int b)
        {
            bool flag = true;
            if(int.TryParse(a, out b))
            {
                flag = false;
            }
            return flag;
        }
        public int pedirNumero()
        {
            int numero;
            do
            {
                Console.WriteLine("Ingrese un numero");

            } while (validarNumero(Console.ReadLine(), out numero));
             return numero;
        }

        public int sumador(int a, int b)
        {
            return a + b;
        }
        public int restador(int a, int b)
        {
            return a - b;
        }
        public int multiplicador(int a, int b)
        {
            return a * b;
        }
        public int divisor(int a, int b)
        {
            if (b==0)
            {
                Console.WriteLine("ERROR, no se puede dividir por 0");
            }
        }

        static void Main(string[] args)
        {
            long num1;
            long num2;
            long acum;

            
            do
            {
                Console.WriteLine("elija un operador. (+.-.*./)");
                switch (Console.ReadLine())
                {
                    case "+":

                        break;
                    case "-":
                        break;
                    case "/":
                        break;
                    case "*":
                        break;
                    default:
                        break;
                }

            } while (true);
            


        }

    }
}
