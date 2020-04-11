using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSamples.Sample2
{
    class Sample
    {
        public static void Do()
        {
            var s = new S();
            s.i = "1";
            using (s)
            {
                Console.WriteLine(s.GetDispose());
                s.i = "2";
            }
            Console.WriteLine(s.GetDispose());
        }
    }

    public class S : IDisposable
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
