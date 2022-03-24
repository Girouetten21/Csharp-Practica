using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConstructor1
{
    //Implementar la clase operaciones. Se deben cargar dos valores enteros en el constructor, calcular su suma, resta, multiplicación y división, cada una en un método, imprimir dichos resultados.

    class Operaciones
    {
        public int V1;
        public int V2;

        public Operaciones()
        {
            Console.WriteLine("Ingresar primer Numero: ");
            V1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar segundo Numero: ");
            V2 = int.Parse(Console.ReadLine());
        }

        public void Suma()
        {
            int Suma;
            Suma = V1 + V2;
            Console.WriteLine("Suma: " + Suma);
        }

        public void Resta()
        {
            int Resta;
            Resta = V1 - V2;
            Console.WriteLine("Resta: " + Resta);
        }

        public void Divicion()
        {
            int Divicion;
            Divicion = V1 / V2;
            Console.WriteLine("Divicion: " + Divicion);
        }

        public void Multiplicacion()
        {
            int Multiplicacion;
            Multiplicacion = V1 * V2;
            Console.WriteLine("Multiplicacion: " + Multiplicacion);
        }

        static void Main(string[] args)
        {
            Operaciones Op = new Operaciones();
            Op.Suma();
            Op.Resta();
            Op.Divicion();
            Op.Multiplicacion();
            Console.ReadKey();
        }
    }
}