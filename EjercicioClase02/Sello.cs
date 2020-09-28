using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase02
{
    class Sello
    {
        #region Atributos

        public static string mensaje;

        public static ConsoleColor color;

        #endregion

        #region Métodos

        public static string ImprimirMensaje()
        {
            Sello.mensaje = ArmarFormatoMensaje(Sello.mensaje);

            return Sello.mensaje;
        }

        public static void BorrarMensaje()
        {
            Sello.mensaje = ("");
        }

        public static void ImprimirMensajeEnColor()
        {
            Console.ForegroundColor = color;

            Console.WriteLine(ImprimirMensaje());

            Sello.color = ConsoleColor.Gray;
            Console.ForegroundColor = color;
        }

        private static string ArmarFormatoMensaje(string mensaje)
        {
            if(mensaje == "") //"if" para evitar que en la consola solo se vean asteriscos.
            {
                return mensaje;
            }
            else
            {
                string formato = "";

                for(int i = 0; i < mensaje.Length + 2; i++)
                {
                    formato += "*";
                }

                mensaje = formato + "\n*" + mensaje + "*\n" + formato;
            }

            return mensaje;
        }

        #endregion
    }
}
