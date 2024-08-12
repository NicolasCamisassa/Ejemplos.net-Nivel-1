using System;

namespace Unidad6
{
    class Program
    {
        static void Main(string[] args)
        {
            // CORTE DE CONTROL casi siempre la arquitectura va a ser while dentro de while. 
            // Sirve para manejar lote de datos agrupados
            // Ejemplo: lejado, edad, sueldo, codigo equipo de futbol
            int legajo, edad, codigoEquipo;
            float sueldo;
            int equipoActual;

            Console.WriteLine("Ingrese el legajo");
            legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo");
            sueldo = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el codigo de equipo");
            codigoEquipo = int.Parse (Console.ReadLine());

            while (sueldo > 0)
             {
                equipoActual = codigoEquipo; 
                while (codigoEquipo == equipoActual)
                 {
                    // aca procesamos
                    
                    
                    Console.WriteLine("Ingrese el legajo");
                    legajo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la edad");
                    edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el sueldo");
                    sueldo = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el codigo de equipo");
                    codigoEquipo = int.Parse (Console.ReadLine());

                    // aca se puede mostrar resultado
                 }
                 // aca se puede mostrar resultado   
             }
             // aca se puede mostrar resultado
        }
    }
}
