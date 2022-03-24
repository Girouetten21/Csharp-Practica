using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesMatematicasBasicas
{
    namespace Tarea2
    {
        //*Implementar la clase operaciones. 
        //* Se deben cargar dos valores enteros, 
        //* calcular su suma, resta, multiplicación y división, cada una en un método, 
        //* imprimir dichos resultados.

        class Operaciones
        {
            public string LG;
            public int Num1, Num2;

            static void Main(string[] args)
            {
                Operaciones Op1 = new Operaciones();
                Op1.TomarNum();

                Console.WriteLine("/////////////////////////////////////");
                Op1.Suma();
                Op1.Resta();
                Op1.Multiplicacion();
                Op1.Division();
                Console.ReadKey();
            }

            public void TomarNum()
            {
                Console.Write("Ingresar primer numero: ");
                LG = Console.ReadLine();
                Num1 = int.Parse(LG);

                Console.Write("Ingresar segundo numero: ");
                LG = Console.ReadLine();
                Num2 = int.Parse(LG);
            }

            public void Suma()
            {
                int ResultadoSuma = 0;
                ResultadoSuma = Num1 + Num2;
                Console.WriteLine("Resultado de la Suma: " + ResultadoSuma);
            }

            public void Resta()
            {
                int ResultadoResta = 0;
                ResultadoResta = Num1 - Num2;
                Console.WriteLine("Resultado de la Resta: " + ResultadoResta);
            }

            public void Multiplicacion()
            {
                int ResultadoMul = 0;
                ResultadoMul = Num1 * Num2;
                Console.WriteLine("Resultado de la Multiplicacion: " + ResultadoMul);
            }

            public void Division()
            {
                int ResultadoDivi = 0;
                ResultadoDivi = Num1 / Num2;
                Console.WriteLine("Resultado de la Division: " + ResultadoDivi);
            }
        }
    }
}
