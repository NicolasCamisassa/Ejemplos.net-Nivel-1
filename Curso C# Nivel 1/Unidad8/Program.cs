using System;

namespace Unidad8
{
    class Program
    {
        static void Main(string[] args)
        {
            //FUNCIONES
            //PARTES DE LA FUNCION
                // Cabecera
                    // 1. Tipo de dato
                    // 2. Nombre
                    // 3. Parametros (opcional)
                // Cuerpo
                    // 1. Definicion/Logica
                    // 2. Retorno de valor o resultado (opcional)

            int n1 = 0, n2 = 0, resultado;

            pedirDatos(ref n1, ref n2);
            
            resultado = sumar(n1, n2);
        
            Console.WriteLine("Resultado: " + resultado);        
        }

        static int sumar(int a, int b)
        {
            int r;
            r = a + b;
            return r;
        }

        static void pedirDatos(ref int j, ref int h)
        {
            Console.WriteLine("Ingresar un numero:");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar otro numero:");
            h = int.Parse(Console.ReadLine());
        }
        
    }
}
