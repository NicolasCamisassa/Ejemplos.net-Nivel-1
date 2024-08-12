using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, par = 0, impar = 0;
            bool bPar = false, bImpar = false;
            
            for (int x = 0; x < 20; x++)
            {
            Console.WriteLine("Ingrese un Nro:");
            n = int.Parse(Console.ReadLine());
                
                if(n % 2 ==0){
                    if(bPar == false){
                       // trabajo con los pares
                        par = n;
                        bPar = true;
                    }else if (n > par)
                        par = n;
                       
                }else{
                    
                    if(bImpar == false){
                        // trabajo con los impares
                        impar = n;
                        bImpar = true;
                    }
                    else if (n < impar){
                        impar = n;
                    }
                }
            }    
            Console.WriteLine("El mayor de los pares es: " + par);
            Console.WriteLine("El menor de los impares es: " + impar);                

            }
        }
    }

