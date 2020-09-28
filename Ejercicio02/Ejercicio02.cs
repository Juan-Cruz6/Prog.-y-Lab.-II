using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Ejercicio02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio02";


            double número;
            double cuadrado;
            double cubo;

            Console.Write("Ingrese número: ");
            número = int.Parse(Console.ReadLine());

            while(número == 0)
            {
                Console.WriteLine("\n\nERROR. ¡Reingresar número! ");
                número = int.Parse(Console.ReadLine());
            }

            cuadrado = Math.Pow(número, 2);
            cubo = Math.Pow(número, 3);

            Console.WriteLine("\n\nEl cuadrado del número ingresado es: {0}\nEl cubo del número ingresado es: {1}", cuadrado, cubo);


            Console.WriteLine("\n\nPresione una tecla para cerrar la consola...");
            Console.ReadKey();
        }
    }
}
