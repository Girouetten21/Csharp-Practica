using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{

    //*Confeccionar una clase que permita ingresar tres valores por teclado. 
    //*Luego mostrar el mayor y el menor.

    class TresChiflados
    {
        public string LG;
        public int Num1, Num2, Num3;
        public int Mayor;
        public int menor;

        public void IngresarDatos()
        {
            Console.Write("Ingresar valor del primer numero: ");
            LG = Console.ReadLine();
            Num1 = int.Parse(LG);

            Console.Write("Ingresar valor del segundo numero: ");
            LG = Console.ReadLine();
            Num2 = int.Parse(LG);

            Console.Write("Ingresar valor del tercero numero: ");
            LG = Console.ReadLine();
            Num3 = int.Parse(LG);

            Mayor = MayorQ(Num1, Num2, Num3);
            menor = menorQ(Num1, Num2, Num3);

            Console.WriteLine("////////////////////////////////");

            Console.WriteLine("El numero mayor de los tres es: " + Mayor);
            Console.WriteLine("El numero menor de los tres es: " + menor);

            Console.ReadKey();
        }

        public int MayorQ(int V1, int V2, int V3)
        {
            int M;

            if (V1 > V2 && V1 > V3)
            {
                M = V1;
            }

            else
            {
                if (V2 > V3)
                {
                    M = V2;
                }

                else
                {
                    M = V3;
                }
            }

            return M;
        }

        public int menorQ(int V1, int V2, int V3)
        {
            int m;

            if (V1 < V2 && V1 < V3)
            {

                m = V1;
            }

            else
            {
                if (V2 < V3)
                {
                    m = V2;
                }

                else
                {
                    m = V3;
                }
            }

            return m;
        }

        static void Main(string[] args)
        {
            TresChiflados TC = new TresChiflados();
            TC.IngresarDatos();
        }
    }
}