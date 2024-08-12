using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Ingrese un Nro");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un otro Nro");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un otro Nro");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un otro Nro");
            d = int.Parse(Console.ReadLine());

            if(a > b && b > c && c > d) 
               Console.WriteLine("Estan ordenados en forma decreciente");

            else
                Console.WriteLine("No estan ordenados");


        }
    }
}
