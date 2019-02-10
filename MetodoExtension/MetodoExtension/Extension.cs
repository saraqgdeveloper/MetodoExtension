using System;

//Clase que implementa un método de extensión, para "agregar" dentro de este proyecto el método EsPositivo, a la clase Integer
//La clase será estática, ya que todos sus atributos y métodos serán estáticos
namespace MetodoExtension
{
    static class Extension
    {
        //Método que "agrega" la funcionalidad, a la clase Integer, de indicar si el entero pasado por parámetro es positivo
        public static bool EsPositivo(this int num1)//Mediante this, indicamos que estamos extendiendo a la clase int
        {
            if ((num1 > 0) || (num1==0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
