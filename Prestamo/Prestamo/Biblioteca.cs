using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamo
{
    internal class Cuenta
    {
        private float cantidad;
        private string Titular;

        //Un constructor que permita inicializar todos los atributos.
        public Cuenta(float c, string t)
        {
            cantidad = c;
            Titular = t;
        }
        // Método getter para el atributo cantidad.
        public float GetCantidad()
        {
            return this.cantidad;
        }

        //Un Método getter para el atributo Titular.
        public string GetTitular()
        {
            return this.Titular;
        }
        //mostrar retornará una cadena de texto con todos los datos de la cuenta.
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("titular de la cuenta {0}", this.GetTitular()));
            sb.AppendLine(string.Format("canntidad de dinero disponible: {0}", this.GetCantidad()));
            return sb.ToString();
        }
        //retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
        public float Retirar(float a)
        {
                return this.cantidad -= a;
        }
        //ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
        public float Ingresar(float a)
        {
            
            return this.cantidad += a;
        }
    }
}
