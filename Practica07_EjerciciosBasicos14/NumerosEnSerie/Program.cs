using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosEnSerie
{
    class Ejercicio4 //Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc. (No se ingresan valores por teclado)
    {
        static void Main(string[] args)
        {
            int Numero = 0;
            int Serie = 1;

            int Contador = 0;
            while (Contador < 25)
            {
                Numero += 11;

                Console.WriteLine("Serie " + Serie + ": " + Numero);
                Serie++;
                Contador++;
            }

            Console.ReadKey();
        }
    }
}
