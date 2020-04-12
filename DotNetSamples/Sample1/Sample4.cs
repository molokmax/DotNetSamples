using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSamples.Sample1
{
    class Sample4 : ISample
    {
        public void Do()
        {
            int i = 1;
            object obj = i;
            ++i;
            Console.WriteLine(i);
            Console.WriteLine(obj);
            Console.WriteLine((short) obj);
        }
    }

}
