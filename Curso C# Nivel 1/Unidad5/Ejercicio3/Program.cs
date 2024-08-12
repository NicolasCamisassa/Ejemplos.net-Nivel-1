using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, promedio, con = 0, suma = 0;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingresar Edad:");
                n = int.Parse(Console.ReadLine());
                if(n > 18){
                    con++;
                    suma += n;
                }
                
            }
            promedio = suma / con;        
            Console.WriteLine("El promedio de las personas mayores a 18 es: " + promedio);


        }
    }
}
