using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//la hipotenusa de un triángulo rectángulo.

namespace Jugo8
{
    class Program
    {
        public int Cateto1 = 0;
        public int Cateto2 = 0;
        public int Hipotenusa = 0;

        public void Resultado()
        {
            Console.WriteLine("Ingresa valor cateto 1");
            string linea = Console.ReadLine();
            Cateto1 = int.Parse(linea);

            Console.WriteLine("Ingresa valor cateto 2");
            linea = Console.ReadLine();
            Cateto2 = int.Parse(linea);

            Hipotenusa = (Cateto2 * Cateto2) + (Cateto1 * Cateto1);
            Console.WriteLine("La hipotenusa es: " + Hipotenusa);
        }

        static void Main(string[] args)
        {
            Program Result = new Program();
            Result.Resultado();
            Console.ReadKey();
        }
    }
}
