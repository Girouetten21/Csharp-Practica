using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Matriz
    {
        public int[,] mat;

        public void CargarMatriz(int a, int b)
        {
            mat = new int[a,b];

            for (int f = 0; f < a; f++)
            {
                for (int c = 0; c < b; c++)
                {
                    Console.Write("Ingresa la matriz: ");
                    mat[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void MostrarMatriz(int a, int b)
        {
            for (int f = 0; f < a; f++)
            {
                for (int c = 0; c < b; c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("o---------------------------------------------o");
            Console.WriteLine();
        }

        public void MostrarDiagonalMatriz(int a, int b)
        {
            Console.WriteLine("----------------Matriz Lineal");

            Console.WriteLine(mat[0, 0]);
            Console.WriteLine(mat[1, 1]);
            Console.WriteLine(mat[2, 2]);
            Console.WriteLine(mat[3, 3]);

            Console.WriteLine("----------------Matriz con FOR anidado");

            for (int f = 0; f < a; f++)
            {
                for (int c = 0; c < b; c++)
                {
                    if (f == c)
                    {
                        Console.WriteLine(mat[f,c] + " ");
                    }
                }
            }


            Console.WriteLine("----------------Matriz con un solo FOR");

            for (int k = 0; k < a; k++)
            {
                Console.WriteLine(mat[k, k] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("o---------------------------------------------o");

        }

        static void Main(string[] args)
        {
            Matriz matriz = new Matriz();
            matriz.CargarMatriz(4,4);
            matriz.MostrarMatriz(4,4);
            matriz.MostrarDiagonalMatriz(4, 4);

            Console.ReadKey();
        }
    }
}
