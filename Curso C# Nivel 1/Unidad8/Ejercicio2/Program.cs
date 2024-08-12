using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
        //    2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.
        //     Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
        
        int n, contador = 0;

        for (int x = 0; x < 5; x++)
        {
            
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            if (par(n))
            {
                contador ++;
            }            
        }
        Console.WriteLine("La cantidad de numeros pares es: " + contador);
        
        }

        static bool par(int a)
        {
            if (a%2 == 0)
            {
                return true;
            }else
                return false;
        }
        
    }
}
