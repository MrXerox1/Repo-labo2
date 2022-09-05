using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public int SetNotaPrimerParcial(int notaAux)
        {
            return this.notaPrimerParcial = notaAux;
        }
        public int SetNotaSegundoParcial(int notaAux)
        {
            return this.notaSegundoParcial = notaAux;
        }

        /*
         * retornará el promedio de las dos notas.
        */
        public float CalcularPromedio()
        {
            float aux;
            aux = this.notaPrimerParcial + this.notaSegundoParcial;
            return aux / 2;
        }
        /* 
         * deberá retornar la nota del final con un numero
         * aleatorio entre 6 y 10 incluidos siempre y cuando las 
         * notas del primer y segundo parcial sean mayores o iguales a
         * 4, caso contrario la inicializará con el valor -1.
        */
        public double CalcularNotaFinal()
        {
            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                return random.Next(6, 10);
            }
            else
            {
                return -1;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Nombre y apellido: {0} {1}", this.nombre, this.apellido));
            sb.AppendLine(string.Format("legajo:{0}", this.legajo));
            sb.AppendLine(string.Format("Nota primer parcial:{0}", this.notaPrimerParcial));
            sb.AppendLine(string.Format("Nota segundo parcial:{0}", this.notaSegundoParcial));
            sb.AppendLine(string.Format("Promedio:{0}", this.CalcularPromedio()));
            if (this.CalcularNotaFinal() == -1)
            {
                sb.AppendLine("Alumno desaprobado");
            }
            else
            {

                sb.AppendLine(string.Format("Nota final:{0}", this.CalcularNotaFinal()));
            }
            return sb.ToString();

        }

    }
}
