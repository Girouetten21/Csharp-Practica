using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altura
{
    class Ejercicio2 //Se ingresan un conjunto de n alturas de personas por teclado. Mostrar la altura promedio de las personas.
{
    static void Main(string[] args)
    {
        float Altura = 0;
        float ContenedorDeAlturas = 0;
        float Promedio;

        int Contador = 0;
        bool Bucle = true;

        while (Bucle)
        {
            Console.Write("Ingresar ALTURA del alumno:");

            float txt = float.Parse(Console.ReadLine());
            Altura = txt;
            ContenedorDeAlturas += Altura;

            Contador++;
            if (Contador == 10) Bucle = false;
        }

        Promedio = ContenedorDeAlturas / 10;

        Console.WriteLine("El promedio de la altura de los alumnos es: "+Promedio);
        Console.ReadLine();
    }
}
}
