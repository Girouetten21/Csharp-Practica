using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//que lea de teclado la marca y modelo de un auto e imprima en pantalla el modelo y la marca(orden invertido a lo que se lee)
namespace Jugo6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar Marca del Auto");
            string Marca = Console.ReadLine();

            Console.WriteLine("Ingresa Modelo del Auto");
            string Modelo = Console.ReadLine();

            Console.WriteLine("El Modelo de su Auto es: " + Modelo);
            Console.WriteLine("La Marca de su Auto es: " + Marca);
            Console.ReadKey();
        }
    }
}
