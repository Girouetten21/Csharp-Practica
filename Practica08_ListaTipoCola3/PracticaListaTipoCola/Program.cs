using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaListaTipoCola
{
    class Cola
    {
        class Nodo
        {
            public int info;
            public Nodo sig;
        }

        private Nodo Inicio, Final;

        public Cola()
        {
            Inicio = null;
            Final = null;
        }

        public bool Vacia()
        {
            if (Inicio == null)
                return true;
            else
                return false;
        }

        public void Insertar(int info)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.sig = null;
            if (Vacia())
            {
                Inicio = nuevo;
                Final = nuevo;
            }
            else
            {
                Final.sig = nuevo;
                Final = nuevo;
            }
        }

        public int Extraer()
        {
            if (!Vacia())
            {
                int informacion = Inicio.info;
                if (Inicio == Final)
                {
                    Inicio = null;
                    Final = null;
                }
                else
                {
                    Inicio = Inicio.sig;
                }
                return informacion;
            }
            else
                return int.MaxValue;
        }

        public void Imprimir()
        {
            Nodo reco = Inicio;
            Console.WriteLine("Listado de todos los elementos de la cola.");

            while (reco != null)
            {
                Console.Write(reco.info + "-");
                reco = reco.sig;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Cola cola1 = new Cola();
            cola1.Insertar(5);
            cola1.Insertar(10);
            cola1.Insertar(50);
            cola1.Imprimir();
            Console.WriteLine("Extraemos uno de la cola:" + cola1.Extraer());
            cola1.Imprimir();
            Console.ReadKey();
        }
    }
}
