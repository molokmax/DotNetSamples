using System;

namespace DotNetSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Sample1:");
            Sample1.Sample.Do();

            Console.WriteLine();
            Console.WriteLine("Sample2:");
            Sample2.Sample.Do();

            Console.ReadKey();
        }
    }
}
