using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Primer ejercicio DE MIERDA";

            Console.WriteLine("Hola mundo de mierda y reputamadrequeteremilparió\n\n");

            Console.Write("Meté tu nombre, pelotudo: ");
            string nombreDelPelotudo = Console.ReadLine();

            Console.WriteLine("\nEl nombre del pelotudo es '{0}'.", nombreDelPelotudo);
            Console.WriteLine();

            Console.Write("Ahora meté tu edad, la reconcha de tu hermana: ");
            int edadDelPelotudo = int.Parse(Console.ReadLine());
            while (edadDelPelotudo <= 0 || edadDelPelotudo >= 126)
            {
                Console.Write("\nMETISTE CUALQUIR COSA, PELOTUDO. ESCRIBI TU PUTA EDAD!! ");
                edadDelPelotudo = int.Parse(Console.ReadLine());
            }

            Console.Write("\nEl nombre del pelotudo es: '{0}', y la edad del pelotudo es: '{1}'.\n", nombreDelPelotudo, edadDelPelotudo);


            Console.WriteLine("\n\nPresione una tecla para cerrar la consola...");
            Console.ReadKey();
        }
    }
}
