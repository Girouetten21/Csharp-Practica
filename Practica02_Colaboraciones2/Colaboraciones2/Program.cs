using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colaboraciones2
{
    /*Plantear una clase Club y otra clase Socio.
    La clase Socio debe tener los siguientes atributos privados: nombre y la antigüedad en el club (en años). 
    En el constructor pedir la carga del nombre y su antigüedad. 
    La clase Club debe tener como atributos 3 objetos de la clase Socio. 
    Definir una responsabilidad para imprimir el nombre del socio con mayor antigüedad en el club.*/

    class Socio
    {
        private string nombre;
        private int antiguedad;

        public Socio()
        {
            Console.WriteLine("Ingresar nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingresar antiguedad");
            antiguedad = int.Parse(Console.ReadLine());
        }

        public int RetornarAntiguedadSocio()
        {
            return antiguedad;
        }

        public string RetornarNombreSocio()
        {
            return nombre;
        }
    }

    class Club
    {
        private Socio Socio1, Socio2, Socio3;

        public void Socios()
        {
            Socio1 = new Socio();
            Socio2 = new Socio();
            Socio3 = new Socio();
        }

        public void SocioMasAntiguo()
        {
            if (Socio1.RetornarAntiguedadSocio() < Socio2.RetornarAntiguedadSocio() && Socio1.RetornarAntiguedadSocio() < Socio3.RetornarAntiguedadSocio())
            {
                if (Socio2.RetornarAntiguedadSocio() < Socio3.RetornarAntiguedadSocio())
                {
                    Console.WriteLine("El socio mas antiguo es: " + Socio3.RetornarNombreSocio());
                }

                else
                {
                    Console.WriteLine("El socio mas antiguo es: " + Socio2.RetornarNombreSocio());
                }
            }

            else
            {
                Console.WriteLine("El Socio mas antiguo es: " + Socio1.RetornarNombreSocio());
            }
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Club peleaClub = new Club();
            peleaClub.Socios();
            peleaClub.SocioMasAntiguo();
            Console.ReadKey();
        }
    }
}