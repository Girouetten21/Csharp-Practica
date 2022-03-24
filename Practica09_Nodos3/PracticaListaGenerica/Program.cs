using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaGenerica1
{
    class ListaGenerica
    {
        private Nodo inicio;

        class Nodo
        {
            public int info;
            public Nodo sig;
        }

        public ListaGenerica()
        {
            inicio = null;
        }

        void Insertar(int pos, int x)
        {
            if (pos <= Cantidad() + 1) //Inicio del Nodo
            {
                Nodo nuevo = new Nodo();
                nuevo.info = x;
                if (pos == 1)
                {
                    nuevo.sig = inicio;
                    inicio = nuevo;
                }

                else
                    if (pos == Cantidad() + 1) //Final del Nodo
                {
                    Nodo reco = inicio;
                    while (reco.sig != null)
                    {
                        reco = reco.sig;
                    }
                    reco.sig = nuevo;
                    nuevo.sig = null;
                }

                else //Centro del Nodo
                {
                    Nodo reco = inicio;
                    for (int f = 1; f <= pos - 2; f++)
                        reco = reco.sig;

                    Nodo siguiente = reco.sig;
                    reco.sig = nuevo;
                    nuevo.sig = siguiente;
                }
            }
        }

        public int Extraer(int pos)
        {
            if (pos <= Cantidad())
            {
                int informacion;

                if (pos == 1)
                {
                    informacion = inicio.info;
                    inicio = inicio.sig;
                }

                else
                {
                    Nodo reco;
                    reco = inicio;
                    for (int f = 1; f <= pos - 2; f++)
                        reco = reco.sig;

                    Nodo prox = reco.sig;
                    reco.sig = prox.sig;
                    informacion = prox.info;
                }
                return informacion;
            }

            else
                return int.MaxValue;
        }

        public void Borrar(int pos)
        {
            if (pos <= Cantidad())
            {
                if (pos == 1)
                {
                    inicio = inicio.sig;
                }
                else
                {
                    Nodo reco;
                    reco = inicio;

                    for (int f = 1; f <= pos - 2; f++)
                        reco = reco.sig;

                    Nodo prox = reco.sig;
                    reco.sig = prox.sig;
                }
            }
        }

        public void Intercambiar(int pos1, int pos2)
        {
            if (pos1 <= Cantidad() && pos2 <= Cantidad())
            {
                Nodo reco1 = inicio;
                for (int f = 1; f < pos1; f++)
                    reco1 = reco1.sig;
                Nodo reco2 = inicio;
                for (int f = 1; f < pos2; f++)
                    reco2 = reco2.sig;
                int aux = reco1.info;
                reco1.info = reco2.info;
                reco2.info = aux;
            }
        }

        public int Mayor()
        {
            if (!Vacia())
            {
                int may = inicio.info;
                Nodo reco = inicio.sig;
                while (reco != null)
                {
                    if (reco.info > may)
                        may = reco.info;
                    reco = reco.sig;
                }
                return may;
            }
            else
                return int.MaxValue;
        }

        public int PosMayor()
        {
            if (!Vacia())
            {
                int may = inicio.info;
                int x = 1;
                int pos = x;
                Nodo reco = inicio.sig;
                while (reco != null)
                {
                    if (reco.info > may)
                    {
                        may = reco.info;
                        pos = x;
                    }
                    reco = reco.sig;
                    x++;
                }
                return pos;
            }
            else
                return int.MaxValue;
        }

        public int Cantidad()
        {
            int cant = 0;
            Nodo reco = inicio;
            while (reco != null)
            {
                reco = reco.sig;
                cant++;
            }
            return cant;
        }

        public bool Ordenada()
        {
            if (Cantidad() > 1)
            {
                Nodo reco1 = inicio;
                Nodo reco2 = inicio.sig;
                while (reco2 != null)
                {
                    if (reco2.info < reco1.info)
                    {
                        return false;
                    }
                    reco2 = reco2.sig;
                    reco1 = reco1.sig;
                }
            }
            return true;
        }

        public bool Existe(int x)
        {
            Nodo reco = inicio;
            while (reco != null)
            {
                if (reco.info == x)
                    return true;
                reco = reco.sig;
            }
            return false;
        }

        public bool Vacia()
        {
            if (inicio == null)
                return true;
            else
                return false;
        }

        public void Imprimir()
        {
            Nodo reco = inicio;
            while (reco != null)
            {
                Console.Write(reco.info + "-");
                reco = reco.sig;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            ListaGenerica lg = new ListaGenerica();
            lg.Insertar(1, 10);
            lg.Insertar(2, 20);
            lg.Insertar(3, 30);
            lg.Insertar(2, 15);
            lg.Insertar(1, 115);
            lg.Imprimir();

            Console.WriteLine("Luego de Borrar el primero");
            lg.Borrar(1);
            lg.Imprimir();

            Console.WriteLine("Luego de Extraer el segundo");
            lg.Extraer(2);
            lg.Imprimir();

            Console.WriteLine("Luego de Intercambiar el primero con el tercero");
            lg.Intercambiar(1, 3);
            lg.Imprimir();

            if (lg.Existe(10)) Console.WriteLine("Se encuentra el 20 en la lista");
            else Console.WriteLine("No se encuentra el 20 en la lista");

            Console.WriteLine("La posición del mayor es:" + lg.PosMayor());

            if (lg.Ordenada()) Console.WriteLine("La lista está ordenada de menor a mayor");
            else Console.WriteLine("La lista no está ordenada de menor a mayor");

            Console.ReadKey();
        }
    }
}
