using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSamples.Sample1
{
    class Sample
    {
        public static void Do()
        {
            //B obj1 = new A();
            //obj1.Foo();

            B obj2 = new B();
            obj2.Foo();

            A obj3 = new B();
            obj3.Foo();
        }
    }

    class A
    {
        public virtual void Foo()
        {
            Console.WriteLine("Class A");
        }
    }
    class B: A
    {
        public override void Foo()
        {
            Console.WriteLine("Class B");
        }
    }
}
