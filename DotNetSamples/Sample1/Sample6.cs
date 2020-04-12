using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DotNetSamples.Sample1
{
    class Sample6 : ISample
    {
        private static Object syncObject = new Object();
        private static void Write()
        {
            lock (syncObject)
            {
                Console.WriteLine("test - " + DateTime.Now.ToString("HH:mm:ss.fff"));
                Thread.Sleep(2000);
            }
        }

        public void Do()
        {
            lock (syncObject)
            {
                Write();
            }

            // lock (syncObject)
            // {
                Task t1 = Task.Run(Write);
                Task t2 = Task.Run(Write);
                Task.WaitAll(t1, t2);
            // }
        }
    }

}
