using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSamples.MailCert
{
    class Sample1 : ISample
    {
        public void Do()
        {
            A a = new A();
            // var m1 = a.M1;
            IA a1 = a;
            var m1 = a1.M1;
            a.M2 = 0;
            var m3 = a.M3;
            var m4 = a.M4();
        }

        interface IA
        {
            int M1 { get; }
            int M2 { set; }
            int M3 { get; set; }
            int M4();
        }
        class A : IA
        {
            int IA.M1 { get { return 0; } }
            public int M2 { set { } }
            public int M3 { get { return 0; } set { } }
            public int M4() { return 0; }
        }
    }
}

