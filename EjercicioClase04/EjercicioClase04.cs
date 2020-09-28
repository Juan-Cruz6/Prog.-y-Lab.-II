using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace EjercicioClase04
{
    class EjercicioClase04
    {
        static void Main(string[] args)
        {
            Console.Title = "EjercicioClase04";


            //AlgoQueNoSeQueEs a = new AlgoQueNoSeQueEs(); //Testeo de la Librería de Clases "Entidades".


            Cosa cosa1 = new Cosa();
            Cosa cosa2 = new Cosa(2);
            Cosa cosa3 = new Cosa(4, "textoDeEjemplo");
            Cosa cosa4 = new Cosa("otroTextoDeEjemplo", 8);

            cosa1.Mostrar("cosa1");
            cosa2.Mostrar("cosa2");
            cosa3.Mostrar("cosa3");
            cosa4.Mostrar("cosa4");


            Console.WriteLine("\n\nPresione una tecla para cerrar la consola...");
            Console.ReadKey();
        }
    }
}
