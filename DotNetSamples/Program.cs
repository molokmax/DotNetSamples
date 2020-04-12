using System;

namespace DotNetSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteSample(new Sample1.Sample1(), "Sample1");
            ExecuteSample(new Sample1.Sample2(), "Sample2");
            ExecuteSample(new Sample1.Sample3(), "Sample3");
            ExecuteSample(new Sample1.Sample4(), "Sample4");


            ExecuteSample(new MailCert.Sample1(), "MailCert.Sample1");

            // Console.ReadKey();
        }

        static void ExecuteSample(ISample sample, string sampleName)
        {
            try
            {
                Console.WriteLine($"Sample '{sampleName}' started");
                sample.Do();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.ToString()}");
            }
            finally
            {
                Console.WriteLine($"Sample '{sampleName}' finished");
                Console.WriteLine();
            }
        }
    }
}
