using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jugo2
{
    class Program
    {
        int Divisor;
        int[] Numeros = new int[20];
        int[] Cociente = new int[20];
        int[] Residuo = new int[20];


        public void IngresarDatos()
        {
            Console.WriteLine("Ingresa Numero DIVISOR");
            string linea = Console.ReadLine();
            Divisor = int.Parse(linea);

            Console.WriteLine("Ingresa 20 Numeros a dividir");
            for (int i = 0; i < 20; i++)
            {
                linea = Console.ReadLine();
                Numeros[i] = int.Parse(linea);
                Console.WriteLine(" ");
            }

            OpCociente();
            OpResiduo();
        }

        public void OpCociente()
        {
            for (int i = 0; i < 20; i++)
            {
                Cociente[i] = (Numeros[i] / Divisor);
            }
        }
        public void OpResiduo()
        {
            for (int i = 0; i < 20; i++)
            {
                Residuo[i] = ((Cociente[i] * Divisor) - Numeros[i]);
            }
        }

        public void MostrarDatos()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("El Cociente y el Residuo de: " + Numeros[i] + " es: ");
                Console.WriteLine(Cociente[i] + " y " + Residuo[i]);
                Console.WriteLine(" ");
            }
        }

        static void Main(string[] args)
        {
            Program Prueba = new Program();
            Prueba.IngresarDatos();
            Prueba.MostrarDatos();
            Console.ReadKey();
        }
    }
}
