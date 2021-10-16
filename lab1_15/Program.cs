using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_15
{
    class A
    {

    }
    class B : A
    {
        public object a;
    }
    class C : B
    {
        public object b;       
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A { };

            B b2 = new B { };
            b2.a = a1;

            B b3 = new B { };
            b3.a = a1;

            C c4 = new C { };
            c4.a = a1;
            c4.b = b2;

            C c5 = new C { };
            c5.a = b3;
            c5.b = c4;
        }
    }
}
