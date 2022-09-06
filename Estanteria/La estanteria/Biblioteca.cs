using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;


        public Producto(string marca, string codigo , float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }
        #region metodos
        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto producto)
        {
            if (!(producto is null))
            {

                StringBuilder sb = new StringBuilder();
                sb.AppendLine(String.Format("Marca: {0}", producto.GetMarca()));
                sb.AppendLine(String.Format("codigo de barras: {0}", (string)producto));
                sb.AppendLine(String.Format("precio: {0}", producto.GetPrecio()));
                return sb.ToString();
                
            }
            return "no hay producto";
        }

        #endregion

        #region Operadores

        public static bool operator !=(Producto producto, string marca)
        {
            bool flag = true;
            if (producto.marca == marca)
            {
                flag = false;
            }
            return flag;
        }
        public static bool operator ==(Producto producto, string marca)
        {
            bool flag = false;
            if (producto.marca == marca)
            {
                flag = true;
            }
            return flag;
        }
        public static bool operator !=(Producto productoA, Producto productoB)
        {
            bool flag = true;
            if (productoA is null || productoB is null ||
                productoA.marca == productoB.marca && productoA.codigoDeBarra == productoB.codigoDeBarra)
            {
                flag = false;
            }
            return flag;
        }
        public static bool operator ==(Producto productoA, Producto productoB)
        {
            bool flag = false;
            if (productoA is null || productoB is null ||
                productoA.marca == productoB.marca && productoA.codigoDeBarra == productoB.codigoDeBarra)
            {
                flag = true;
            }
            return flag;
        }

        public static explicit operator String(Producto p)
        {
            return p.codigoDeBarra;
        }
        #endregion


    }

    internal class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return productos;
        }

        public static string MostrarEstante(Estante e)
        {
            Producto[] aux = e.GetProductos();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---Lista de productos---");
            foreach (Producto p in aux)
            {
                sb.AppendLine(Producto.MostrarProducto(p));
                sb.AppendLine("----------------------");
            }
            return sb.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            Producto[] aux = e.GetProductos();
            bool flag = false;
            foreach (Producto producto in aux)
            {
                if (producto == p)
                {
                    return true;
                }
            }
            return flag;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            Producto[] aux = e.GetProductos();
            bool flag = true;
            foreach (Producto producto in aux)
            {
                if (producto == p)
                {
                    return false;
                }
            }
            return flag;
        }

        public static bool operator +(Estante e, Producto p)
        {
            Producto[] aux = e.GetProductos();
            bool flag = false;
            int i = 0;
            foreach (Producto producto in aux)
            {
                if (!aux.Contains(p) && producto is  null)
                {
                    e.productos[i]=p;
                    flag = true;
                    break;
                }
                else if(producto is not null && producto == p)
                {
                    break;
                }
                i++;
            }
            return flag;
        }

        public static bool operator -(Estante e, Producto p)
        {
            Producto[] aux = e.GetProductos();
            bool flag = true;
            int i = 0;
            foreach (Producto producto in aux)
            {
                if (producto == p)
                {
                    aux[i] = null;

                }
                i++;
            }
            return flag;
        }
    }
}
