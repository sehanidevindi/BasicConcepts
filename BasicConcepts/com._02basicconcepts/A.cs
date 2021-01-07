using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcepts.com._02basicconcepts
{
    interface IA
    {
        void MethodA();
        void MethodB();
        
    }

    class B : IA 
    {

        public void MethodA()
        {
            Console.WriteLine("B - MA");
        }
        public void MethodB()
        {
            Console.WriteLine("B - MB");
        }
    }

    class Test {
        static void Main()
        {

           // Console.WriteLine("A obj");
           // IA aobj = new A();
           // aobj.MethodA();

            Console.WriteLine("B obj");
            B bobj = new B();
            bobj.MethodA();
            bobj.MethodB();

            Console.WriteLine("A or B?");
            int x = 23;
            IA obj1 = new B();
            obj1.MethodA();
            obj1.MethodB();

        }
    }
}
