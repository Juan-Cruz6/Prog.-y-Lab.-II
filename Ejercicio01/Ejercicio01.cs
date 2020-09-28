using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Ejercicio01
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio01";


            int número;
            int máximo = 0;
            int mínimo = 0;
            int promedio = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese número: ");
                número = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    máximo = número;
                }
                else if (número > máximo)
                {
                    máximo = número;
                }

                if (i == 0)
                {
                    mínimo = número;
                }
                else if (número < mínimo)
                {
                    mínimo = número;
                }

                promedio = número + promedio;
            }

            promedio = promedio / 5;


            Console.Write("El máximo es: {0}\nEl mínimo es: {1}\nEl promedio es: {2}\n", máximo, mínimo, promedio);


            Console.WriteLine("\n\nPresione una tecla para cerrar la consola...");
            Console.ReadKey();
        }
    }
}
