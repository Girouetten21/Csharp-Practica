using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jugo4
{
    class Program
    {
        public int[] Num = new int[15];
        public int SumaTotal;

        public void Datos()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Ingresa 15 numeros");
                string linea = Console.ReadLine();
                Num[i] = int.Parse(linea);

                if (Num[i] < 50 || Num[i] > 500)
                {
                    Console.WriteLine("ERROR NUMERO MAYOR QUE 50 O MENOR QUE 500 MMGVO");
                    i--;
                    //break;
                }
            }
        }

        public void Suma()
        {
            for (int i = 0; i < 15; i++)
            {
                SumaTotal = SumaTotal + Num[i];
            }

            Console.WriteLine("Suma total de los 15 numero es: " + SumaTotal);
        }

        static void Main(string[] args)
        {
            Program Program = new Program();
            Program.Datos();
            Program.Suma();
            Console.ReadKey();
        }
    }
}
