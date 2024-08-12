using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, mayor=0;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un Nro:");
                n = int.Parse(Console.ReadLine());
                if(x == 0)
                    mayor = n;
                else{
                    if(n > mayor)
                        mayor = n;   
                    }

                }
            
                Console.WriteLine("El Nro mayor es: " + mayor);
        }
    }
}
