using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSamples.MailCert
{
    class Sample3 : ISample
    {
        public void Do()
        {
            // A a = new A(1f);
        }

        public struct A
        {
            public bool val;
            // public A() { val = true; } // error
            public A(double a) { this = new A(); } // OK???
            // public A(float a) { } // error
            public A(bool a) { val = a; }
            public A(char a) { val = a == 'a'; }
        }
    }
}

