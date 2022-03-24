using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplosDe8
{
    class Ejercicio5 //Mostrar los múltiplos de 8 hasta el valor 500. Debe aparecer en pantalla 8 - 16 - 24, etc.
    {
        static void Main(string[] args)
        {
            int Numero = 0;
            int multiplicador = 0;

            while (Numero < 500)
            {
                Numero = 8;
                Numero = Numero * multiplicador;

                Console.WriteLine(Numero);
                multiplicador++;
            }

            Console.ReadKey();
        }
    }
}
