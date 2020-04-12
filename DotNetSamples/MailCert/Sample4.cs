using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSamples.MailCert
{
    class Sample4 : ISample
    {
        public void Do()
        {
            int x = 1;
            switch (x)
            {
                case 1:
                    test:
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine();
                    goto case 1;
                case 3:
                    Console.WriteLine();
                    goto test;
                //case 4:
                //    Console.WriteLine();
                case 5:
                    while (true)
                        Console.WriteLine();
                case 6:
                case 7:
                    throw new Exception();
                //default:
                //    Console.WriteLine();
                //    break;
            }
        }
    }
}

