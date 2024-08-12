using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            char L1, L2;

            Console.WriteLine("Ingrese Frase: ");
            frase = Console.ReadLine();
            Console.WriteLine("Ingrese letra caracter 1: ");
            L1 = char.Parse(Console.ReadLine());
            Console.WriteLine("ingrese Caracter 2: ");
            L2 = char.Parse(Console.ReadLine());

            frase = frase.Replace(L1, L2);

            Console.WriteLine("La frase nueva es: ");
            Console.Write(frase);
        }
    }
}
