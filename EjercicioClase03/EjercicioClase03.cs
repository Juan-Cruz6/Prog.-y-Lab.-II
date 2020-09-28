using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase03
{
    class EjercicioClase03
    {
        static void Main(string[] args)
        {
            Console.Title = "EjercicioClase03";


            AlgoQueNoSeQueEs miPrimeritoObjeto = new AlgoQueNoSeQueEs(); //Uso del constructor de instancia por defecto.
            AlgoQueNoSeQueEs miSegunditoObjeto = new AlgoQueNoSeQueEs(16, "ola ke ase"); //Uso del constructor de instancia parametrizado.

            AlgoQueNoSeQueEs miTerceritoObjeto = miPrimeritoObjeto; //Ahora, "miTerceritoObjeto" apunta a la misma posicion de memoria (en el "heap") que "miPrimeritoObjeto", por lo cual sus valores son los mismos.


            AlgoQueNoSeQueEs.unAburridoAtributoEstatico = 8;

            miPrimeritoObjeto.miPrimeritoAtributoNoEstatico = 32;
            miSegunditoObjeto.miPrimeritoAtributoNoEstatico = 64;


            miPrimeritoObjeto.MiPrimeritoMetodoNoEstatico();

            miSegunditoObjeto.MiPrimeritoMetodoNoEstatico();


            Console.WriteLine("\n\nPresione una tecla para cerrar la consola...");
            Console.ReadKey();
        }
    }
}
