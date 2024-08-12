using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
        // Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

        // El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
        // Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

            int n, conNumeros, conImpares, grupoImparesMaximos = 0, minimo, conOrdenados = 0;
            double porcentajeImpares, porcentajeMaximo = -1; 
            bool banderaOrdenados;

            for (int x = 0; x < 5; x++)
            {
                conNumeros = 0;
                conImpares = 0;
                banderaOrdenados = true;
                n = int.Parse(Console.ReadLine());
                minimo = n;
                while (n != 0)
                {
                    conNumeros ++;
                    if (n % 2 != 0)
                        conImpares++;   
                    
                    if (n <= minimo)
                        minimo = n;
                    else 
                        banderaOrdenados = false;
                    
                    n = int.Parse(Console.ReadLine());
                }
                porcentajeImpares = conImpares * 100 / conNumeros;
                if(porcentajeImpares > porcentajeMaximo)
                    {
                    porcentajeMaximo = porcentajeImpares;
                    grupoImparesMaximos = x + 1;
                    }

                if(banderaOrdenados)
                    conOrdenados++;    
                
            }

            Console.WriteLine("El grupo con mayor porcentaje de impares es: " + grupoImparesMaximos);    
            Console.WriteLine("La cantidad de grupos con numeros ordenados es: " + conOrdenados);
        }

    }
}
