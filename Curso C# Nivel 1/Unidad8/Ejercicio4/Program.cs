using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. 
            // Que analice el número y escriba variable recibida por referencia con:

            // a. 1 si el número es positivo.
            // b. -1 si el número es negativo.
            // c. 0 si el número es cero.
            
            int positivo = 0, negativo = 0, cero = 0, ban = 0;
            
            for (int x = 0; x < 4; x++)
            {
                int n;
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                positivoNegativoCero(n, ref ban);
                switch (ban)
                {
                    case 1:
                        positivo ++;
                        break;
                    case 0:
                        cero ++;
                        break;              
                    case -1:
                        negativo ++;
                        break;
                }
                
            }
            
            Console.WriteLine("La cantidad de positivos es: " + positivo);
            Console.WriteLine("La cantidad de negativos es: " + negativo);
            Console.WriteLine("La cantidad de ceros es: " + cero);

        }

        static void positivoNegativoCero (int a, ref int b)
        {
            if (a > 0)
                b = 1;
            else if (a == 0)
                b = 0;
            else
                b = -1;
        }
    }
}
