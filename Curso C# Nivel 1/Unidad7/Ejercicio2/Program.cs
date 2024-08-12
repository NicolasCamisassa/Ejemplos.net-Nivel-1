using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite 10  números enteros y los guarde en un vector.
            // Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.
        
            
            int[] numeros = new int[4];
            int acu = 0, promedio;

            for (int x = 0; x < 4; x++)
            {   
               Console.WriteLine("Ingrese un numero: ");
               numeros [x] = int.Parse(Console.ReadLine());
            }
            
            for (int x = 0; x < 4; x++)
            {
                acu += numeros[x];
            }

            promedio = acu / 4;
            Console.WriteLine("El promedio es: " + promedio);

            for (int x = 0; x < 4; x++)
            {
                if(numeros [x] > promedio)
                    Console.WriteLine("El numero mayor al promedio es: " + numeros[x]);
            }




        
        }

    }
}
