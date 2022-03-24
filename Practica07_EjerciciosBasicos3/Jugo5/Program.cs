using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//la suma de tres(3) números enteros impares inferiores a 400.


namespace Jugo5
{
    class Program
    {
        public int[] Num = new int[3];
        public int SumaTotal;

        public void Datos()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingresa 3 numeros");
                string linea = Console.ReadLine();
                Num[i] = int.Parse(linea);

                if (Num[i] > 400 || (Num[i] % 2) == 0)
                {
                    Console.WriteLine("El numero debe ser inferior a 400 y ser un numero IMPAR");
                    i--;
                    //break;
                }
            }
        }

        public void Suma()
        {
            for (int i = 0; i < 3; i++)
            {
                SumaTotal = SumaTotal + Num[i];
            }

            Console.WriteLine("Suma total de los 3 numero es: " + SumaTotal);
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
