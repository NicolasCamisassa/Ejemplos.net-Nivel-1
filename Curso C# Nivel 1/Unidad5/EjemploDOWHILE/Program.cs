using System;

namespace EjemploDOWHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0;

            do{
                Console.WriteLine("Hello World!");
                n = int.Parse(Console.ReadLine());
                con++;
            }while(n != 0);

            Console.WriteLine("Ingresaste: " + con + " nros.");
        }
    }
}
