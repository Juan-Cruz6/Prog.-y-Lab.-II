using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EjercicioClase02";


            #region 1ra parte

            Sello.mensaje = "Tu mami huele a chivo"; //Se le asigna un contenido al atributo "Mensaje" de la clase "Sello".


            Console.WriteLine(Sello.ImprimirMensaje()); //Se muestra por consola lo asignado en el atributo "Mensaje" de la clase "Sello".

            Sello.BorrarMensaje(); //Se remplaza el contenido de el atributo "Mensaje" de la clase "Sello" por un espacio en blanco.

            Console.WriteLine(Sello.ImprimirMensaje()); //Se vuelve a mostrar por consola lo asignado en el atributo "Mensaje" de la clase "Sello" para comprobar que su contenido se ha "borrado".

            #endregion

            #region 2da parte

            Sello.mensaje = "Hola mundo";

            Sello.color = ConsoleColor.Red;

            Sello.ImprimirMensajeEnColor();

            #endregion

            #region 3ra parte

            Sello.mensaje = "Texto de ejemplo";

            Console.WriteLine(Sello.ImprimirMensaje());

            #endregion


            Console.WriteLine("\n\nPresione una tecla para cerrar la consola...");
            Console.ReadKey();
        }
    }
}
