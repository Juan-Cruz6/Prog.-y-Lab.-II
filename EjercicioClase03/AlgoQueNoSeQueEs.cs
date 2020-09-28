using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase03
{
    class AlgoQueNoSeQueEs
    {
        #region Atributos y métodos ESTATICOS

        #region Atributos

        public static int unAburridoAtributoEstatico;

        public static string otroAburridoAtributoEstatico;

        #endregion

        #region Métodos



        #endregion

        #region Apuntes y anotaciones

        //TODOS los métodos y atributos ESTATICOS son accesibles de la siguiente manera: " NombreDeLaClase.nombreDelAtributo/NombreDelMétodo; "

        #endregion

        #endregion
        

        #region Atributos y métodos NO ESTATICOS 

        #region Atributos

        public int miPrimeritoAtributoNoEstatico;

        public string miSegunditoAtributoNoEstatico;

        #endregion

        #region Métodos

        public void MiPrimeritoMetodoNoEstatico()
        {
            Console.WriteLine("El aburrido atributo estático vale: {0}\n\nMientras que el superespectacularmenteincreible:D atributo no estático vale: {1}\n\n", AlgoQueNoSeQueEs.unAburridoAtributoEstatico, this.miPrimeritoAtributoNoEstatico);
        }

        #endregion

        #region Apuntes y anotaciones

        //TODOS los métodos y atributos NO ESTATICOS son accesibles de la siguiente manera: " NombreDeLaClase nombreDelObjeto = new  NombreDeLaClase(); ". (Declaración e instanciamiento de un objeto de la clase "NombreDeLaClase").

        //" nombreDelObjeto.nombreDelAtributo/NombreDelMétodo... ;". (Uso del atributo/método de la clase "NombreDeLaClase" a través del objeto creado anteriormente).

        #endregion

        #endregion


        #region constructor ESTATICO

        static AlgoQueNoSeQueEs() //Constructor por defecto
        {
            AlgoQueNoSeQueEs.unAburridoAtributoEstatico = 0;

            AlgoQueNoSeQueEs.otroAburridoAtributoEstatico = "Hola. Soy un aburrido atributo estático equisde";
        }

        #endregion

        #region constructores NO ESTATICOS

        public AlgoQueNoSeQueEs() //Constructor por defecto
        {
            this.miPrimeritoAtributoNoEstatico = 0;

            this.miSegunditoAtributoNoEstatico = "tuNoHasVistoNada :O";
        }

        public AlgoQueNoSeQueEs(int primerParametro, string segundoParametro) //Constructor parametrizado
        {
            this.miPrimeritoAtributoNoEstatico = primerParametro;

            this.miSegunditoAtributoNoEstatico = segundoParametro;
        }

        #endregion
    }
}
