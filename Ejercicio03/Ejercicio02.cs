using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Ejercicio03
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio03";


            int num;
            int cont;

            Console.Write("Ingrese un número mayor a '1': ");
            num = int.Parse(Console.ReadLine());

            while(num <= 1)
            {
                Console.Write("\n\nError, Ingrese un número mayor a '1': ");
                num = int.Parse(Console.ReadLine());
            }

            Console.Write("\nLos números primos hasta el número ingresado son: ");

            for (int i = num; i > 1; i--)
            {
                cont = 0;

                for (int j = 1; j < (num + 1); j++)
                {
                    if (num % j == 0)
                    {
                        cont++;
                    }
                }
                
                if(cont == 2)
                {
                    Console.Write("{0}, ", num);
                }

                num--;
            }


            Console.WriteLine("\n\nPresione una tecla para cerrar la consola...");
            Console.ReadKey();
        }
    }
}
