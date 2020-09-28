using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Ejercicio04
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio04";


            int contYaEstanLosCuatro = 0;
            int acumSumaDeLosDivisores;

            Console.Write("Los cuatro primeros números perfectos son: ");

            for (int i = 1; contYaEstanLosCuatro != 6; i++)
            {
                acumSumaDeLosDivisores = 0;

                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        acumSumaDeLosDivisores += j;
                    }
                }

                if (acumSumaDeLosDivisores == i)
                {
                    Console.Write("{0} ", i);

                    contYaEstanLosCuatro++;
                }
            }


            Console.WriteLine("\n\nPresione una tecla para cerrar la consola...");
            Console.ReadKey();
        }
    }
}
