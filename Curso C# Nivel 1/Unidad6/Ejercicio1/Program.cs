using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con, cantidad = 0;
            
            for (int y = 0; y < 5; y++)
            {    
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
                con = 0;
            
                for (int x = 1; x <= n; x++)
                {
                    if (n % x == 0)
                    con ++;
                }
                if (con ==2)
                    cantidad ++;          
            }
            Console.WriteLine("La cantidad de numeros primos son: " + cantidad);

        }
    }
}
