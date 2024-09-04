using System;

namespace TPFinal_Camisassa
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

            // a. El mayor de los números pares.
            // b. La cantidad de números impares.
            // c. El menor de los números primos.

            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.
        
            int n, par = 0, impar;
            int maximoPar = 0, cantidadImpares = 0, minimoPrimo = 0;
            
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                if (n % 2 == 0)
                {
                    par = n;                   
                }else
                    impar = n;
                
                
                if (par == n)
                {
                    if (maximoPar == 0)
                    {
                        maximoPar = n;    
                    }else if (n > maximoPar)
                        maximoPar = n;
                }else
                    cantidadImpares ++;
                    
                if(primos(n))
                {               
                    if (minimoPrimo == 0)
                    {   
                        minimoPrimo = n;
                    }else if (n < minimoPrimo)
                        minimoPrimo = n;
                }

                Console.WriteLine("Ingrese otro numero para continuar o 0 para salir: ");
                n = int.Parse(Console.ReadLine());
            }
                        
            Console.WriteLine("El mayor de los numeros pares es: " + maximoPar);
            Console.WriteLine("La cantidad de numeros impares es: " + cantidadImpares);
            Console.WriteLine("El menor de los numeros primos es: "+ minimoPrimo);
        }

        static bool primos(int a)
        {
            int contador = 0;
            for (int x = 1; x <= a; x++)
            {
                if (a % x == 0)
                {
                    contador ++;
                }    
            }
            if (contador == 2)
            {
                return true;
            }else
                return false;
        }
    }
}