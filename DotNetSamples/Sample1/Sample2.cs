using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSamples.Sample1
{
    class Sample2 : ISample
    {
        public void Do()
        {
            var s1 = new S();
            using (s1)
            {
                Console.WriteLine(s1.GetDispose());
                s1.i = "2";
            }
            Console.WriteLine(s1.GetDispose());

            //using (var s2 = new S())
            //{
            //    Console.WriteLine(s2.GetDispose());
            //    s2.i = "2";
            //}

        }

        public struct S : IDisposable
        {
            public string i;
            private bool dispose;
            public void Dispose()
            {
                Console.WriteLine("disposing");
                dispose = true;
            }
            public bool GetDispose()
            {
                return dispose;
            }
        }
    }
}
