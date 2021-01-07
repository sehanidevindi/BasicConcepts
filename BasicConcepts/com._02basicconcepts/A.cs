using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcepts.com._02basicconcepts
{
    class A
    {
        public virtual void MethodA() {
            Console.WriteLine("A - MA");
        }
    }

    class B : A {

        public override void MethodA()
        {
            Console.WriteLine("B - MA");
        }
        public void MethodB()
        {
            Console.WriteLine("B - MB");
        }
    }

    class Test {
        static void Main() {

            Console.WriteLine("A obj");
            A aobj = new A();
            aobj.MethodA();

            Console.WriteLine("B obj");
            B bobj = new B();
            bobj.MethodA();
            bobj.MethodB();

            Console.WriteLine("A or B?");
            int x = 10;
            A obj1 = new B();
            obj1.MethodA();

        }
    }
}
