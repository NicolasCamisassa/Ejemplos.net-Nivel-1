using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
            // Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.
            
            int cantidadVendida, precioArticulo, montoTotal;

            Console.WriteLine("Ingrese precio de Articulo: ");
            precioArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad Vendida: ");
            cantidadVendida = int.Parse(Console.ReadLine());

            montoTotal = producto(precioArticulo, cantidadVendida);

            Console.WriteLine("El monto total a pagar es " + montoTotal);
        }

        static int producto(int a, int b)
        {
            int r;
            r = a * b;
            return r;
        }
    }
}
