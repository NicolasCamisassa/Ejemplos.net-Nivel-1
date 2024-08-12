using System;

namespace EjemploFOR
{
    class Program
    {
        static void Main(string[] args)
        {
            // CICLO FOR
            // for(int x = 0; x < 5; x++){
            //     Console.WriteLine("Hola Mundo " + x);
                
            //} 

            int n = 0, promedio, suma = 0;      


            for (int x = 0; x < 5; x++)
            {
            Console.WriteLine("Ingrese un Nro");
            n = int.Parse(Console.ReadLine());
            suma += n;            
            }
            promedio = suma / 5;
            Console.WriteLine("El promedio es: " + promedio);
        }
    }
}
