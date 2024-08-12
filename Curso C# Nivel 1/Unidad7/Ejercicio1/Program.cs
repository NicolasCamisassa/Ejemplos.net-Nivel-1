using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
            //  Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

            
            int[] numeros = new int [4];
            int maximo = numeros[0], posicion = 1;
          
            for (int x = 0; x < 4; x++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numeros[x] = int.Parse(Console.ReadLine());
               
            }
            
            for (int x = 0; x < 4; x++)
            {
                if(numeros[x] > maximo){
                    maximo = numeros[x];
                    posicion = x+1;    
                }
            }
            Console.WriteLine("El valor maximo es " + maximo + " en la posicion: " + posicion);


        }
    }
}
