using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
                // Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
                // - Número de Artículo (1 a 15)
                // - Cantidad Vendida 

                // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
                // Se pide determinar e informar:
                // a) El número de artículo que más se vendió en total.
                // b) Los números de artículos que no registraron ventas.
                // c) Cuantas unidades se vendieron del número de artículo 10.

            int[] Acu = new int [15];
            int NumerosArticulo, cantidadVendida;
        
             for (int x = 0; x < 15; x++)
            {
                Acu[x] = 0; 
            }

            Console.WriteLine("Ingrese numero de articulo: ");
            NumerosArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Cantidad Vendida: ");
            cantidadVendida = int.Parse(Console.ReadLine());
            
            while (NumerosArticulo != 0)
            {
                Acu[NumerosArticulo - 1] += cantidadVendida;
                
                Console.WriteLine("Ingrese numero de articulo: ");
                NumerosArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Cantidad Vendida: ");
                cantidadVendida = int.Parse(Console.ReadLine());

            } 
            
            // PUNTO A
            int maximo = Acu[0];
            int Articulo = 1;
            for (int x = 0; x < 15; x++)
            {
                if (Acu[x] > maximo){
                    maximo = Acu[x];
                    Articulo = x + 1;
                }
            }
            Console.WriteLine("El articulo que mas se vendio es:" + Articulo + " con la cantidad de: " + maximo);

            // PUNTO B  
            for (int x = 0; x < 15; x++)
            {
                if (Acu[x] == 0)
                {
                    Console.WriteLine("El Articulo " + (x + 1) + " no tuvo ventas");
                }   
            }

            // PUNTO C
            Console.WriteLine("La cantidad vendida del articulo 10 es: " + Acu[9]);


            
            

                  
        }
    }
}
