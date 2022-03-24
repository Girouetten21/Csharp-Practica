using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    //*Confeccionar una clase que represente un empleado. 
    //*Definir como atributos su nombre y su sueldo. 
    //*Confeccionar los métodos para la carga, 
    //*Otro para imprimir sus datos 
    //*y por último uno que imprima un mensaje si debe pagar impuestos (si el sueldo supera a 3000)

    class Empleado
    {
        public string LG;
        public string Nombre;
        public float Sueldo;
        private float Impuestos = 3000f;

        static void Main(string[] args)
        {
            Empleado Emp1 = new Empleado();
            Emp1.TomarDatos();
            Emp1.ImprimirDatos();
            Console.ReadKey();
        }

        public void TomarDatos()
        {
            Console.Write("Ingresa nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingresar sueldo: ");
            LG = Console.ReadLine();
            Sueldo = float.Parse(lg);


        }

        public void ImprimirDatos()
        {
            Console.WriteLine("/////////////////////////////////");
            Console.WriteLine("Nombre del Empleado: " + Nombre);
            Console.WriteLine("Sueldo del Empleado: " + Sueldo + "$");

            if (Sueldo > Impuestos)
            {
                Console.WriteLine("Usted gana mucha plata, debe pagar impuestos");
            }

            else
            {
                Console.WriteLine("Usted no paga impuestos");
            }

        }
    }

}