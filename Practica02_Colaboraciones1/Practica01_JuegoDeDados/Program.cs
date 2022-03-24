using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01_JuegoDeDados
{
    /* Dado		
    atributos
        valor
    métodos
        constructor
        Tirar
        Imprimir
        RetornarValor

JuegoDeDados
    atributos
        3 Dado (3 objetos de la clase Dado)
    métodos
        constructor
        Jugar

Creamos un proyecto llamado: Colaboracion2 y dentro del proyecto creamos dos clases llamadas: Dado y JuegoDeDados.*/

    class Dados
    {
        private int DadoValor;
        private static Random Aleatorio;

        public Dados()
        {
            Aleatorio = new Random();
        }

        public void TirarDado()
        {
            DadoValor = Aleatorio.Next(1, 7);
        }

        public void ImprimirValorDado()
        {
            Console.WriteLine("Valor del dado es: " + DadoValor);
        }

        public int RetornarValor()
        {
            return DadoValor;
        }
    }

    class JuegoDeDados
    {
        private Dados Dado1, Dado2, Dado3;

        public JuegoDeDados()
        {
            Dado1 = new Dados();
            Dado2 = new Dados();
            Dado3 = new Dados();
        }

        public void JugarDados()
        {
            Dado1.TirarDado();
            Dado1.ImprimirValorDado();

            Dado2.TirarDado();
            Dado2.ImprimirValorDado();

            Dado3.TirarDado();
            Dado3.ImprimirValorDado();

            if (Dado1.RetornarValor() == Dado2.RetornarValor() && Dado1.RetornarValor() == Dado3.RetornarValor())
            {
                Console.WriteLine("Ganó");
            }
            else
            {
                Console.WriteLine("Perdió");
            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            JuegoDeDados j = new JuegoDeDados();
            j.JugarDados();
        }
    }
}