using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    class A
    {
        public A (int a)
        {
            Console.WriteLine("Numero de A: " + a);
        }
    }

    class B:A
    {
        public B(int b):base(b+1)
        {
            Console.WriteLine("Numero de B: " + b);
        }
    }

    class C:B
    {
        public C(int c):base(c+5)
        {
            Console.WriteLine("Numero de C: " + c);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            C objetoC = new C(1);
            Console.WriteLine("-----------------");
            B objetoB = new B(9);
            Console.WriteLine("-----------------");
            A objetoA = new A(100);
            Console.ReadKey();
        }
    }
}
