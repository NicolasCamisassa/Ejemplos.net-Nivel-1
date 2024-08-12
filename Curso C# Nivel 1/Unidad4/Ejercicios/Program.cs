using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            // AND y OR ....... NOT
            // AND: &&
            // OR: ||
            // NOT: !

            int edad = 20;
            char inicial = 'J';
            // true     &&     true
            if(edad > 20 && inicial == 'H'){
                Console.WriteLine("21 OFF");
            }
            // true       ||   true
            if (edad > 20 || inicial == 'H'){

            }
            if ((inicial == 'H' || inicial == 'J') && !(edad > 20)){
                
            }


        }
    }
}
