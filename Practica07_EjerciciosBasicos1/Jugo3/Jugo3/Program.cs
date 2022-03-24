using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jugo3
{
    class Pentagono
    {
        public int Perimetro;
        public int[] Lados = new int[] {1,10,15,20,25} ;
        public int Apodema = 10;
        public int Area;

        public void CalculoPerimetro()

        { 
            for (int i = 0; i < 5; i++)
            {
                Perimetro = Perimetro + Lados[i];
            }

            Console.WriteLine("El Perimetro del Pentagono es: " + Perimetro);
        }

        public void CalculoArea()
        {
            Area = (Perimetro * Apodema) / 2;
            Console.WriteLine("El Area del Pentagono es: " + Area);

            if ((Area % 2) == 0)
            {
                Console.WriteLine("Area Par, no se hace nada");
            }

            else
            {
                for (int i = 1; i < 11; i++)
                {
                    Area = Area * i;
                    Console.WriteLine(i + " * Area: " + Area);
                }
            }
        }

        static void Main(string[] args)
        {
            Pentagono Prueba = new Pentagono();
            Prueba.CalculoPerimetro();
            Prueba.CalculoArea();
            Console.ReadKey();
        }
    }
}
