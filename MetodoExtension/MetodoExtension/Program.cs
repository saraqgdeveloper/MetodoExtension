using System;

namespace MetodoExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            //Al ser estática la clase Extension, no podemos instanciarla. Veremos que el método de extensión
            //está integrado en la clase Integer, a efectos de este proyecto, por lo que podremos usarlo sin problemas.

            int numero1 = 15;

            bool signo = numero1.EsPositivo();

            if (signo)
            {
                Console.WriteLine("El número {0} es un número positivo", numero1);
            }
            else
            {
                Console.WriteLine("El número {0} es un número negativo", numero1);
            }

        }
    }
}
