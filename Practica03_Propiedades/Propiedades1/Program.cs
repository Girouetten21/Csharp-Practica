using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades1
{
    class Socio
    {
        private int monto;
        public int Monto
        {
            set
            {
                if (value >= 0)
                {
                    monto = value;
                }
                else
                {
                    Console.WriteLine("Ingresar un valor mayor a 0");
                }
            }
            get
            {
                return monto;
            }
        }

        private string nombre;
        public string Nombre
        {
            set
            {
                nombre = value;
            }

            get
            {
                return nombre;
            }
        }
    }

    class Banco
    {
        private Socio Socio1, Socio2, Socio3;

        public Banco()
        {
            Socio1 = new Socio();
            Socio2 = new Socio();
            Socio3 = new Socio();

            Socio1.Nombre = "Manuel";
            Socio2.Nombre = "Manuela";
            Socio3.Nombre = "Manito";

            Socio1.Monto = 100;
            Socio2.Monto = 0;
            Socio3.Monto = 10;
        }

        public void DepositosSocios()
        {
            int t = Socio1.Monto + Socio2.Monto + Socio3.Monto;
            Console.WriteLine("El total del dinero en el banco es; " + t);
        }

        public void ImprimirSocios()
        {
            Console.WriteLine("Nombre: " + Socio1.Nombre + " - " + "Monto: " + Socio1.Monto);
            Console.WriteLine("Nombre: " + Socio2.Nombre + " - " + "Monto: " + Socio2.Monto);
            Console.WriteLine("Nombre: " + Socio3.Nombre + " - " + "Monto: " + Socio3.Monto);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Banco banco1 = new Banco();
            banco1.ImprimirSocios();
            banco1.DepositosSocios();
            Console.ReadKey();
        }
    }
}
