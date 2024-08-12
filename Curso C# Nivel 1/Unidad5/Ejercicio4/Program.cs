using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0;
                Console.WriteLine("Ingrese un Nro:");
                n = int.Parse(Console.ReadLine());
            
            for(int x = 1; x <= n; x++)
            {
                if(n % x == 0)
                    con++;
            }
            if(con == 2)
                Console.WriteLine("Es primo");
            else
                Console.WriteLine("No es primo");
        }
    }
}
