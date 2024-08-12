using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
            // Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.
        
            int n, conPrimos = 0, acuPrimos = 0, promedio;
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                
                if(primos(n))
                {
                    conPrimos ++;
                    acuPrimos += n;
                }
                
                Console.WriteLine("Ingrese otro numero para continuar o 0 para salir: ");
                n = int.Parse(Console.ReadLine());             
            }
            promedio = acuPrimos / conPrimos;
            Console.WriteLine("El promedio de los numeros primos es " + promedio);
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
