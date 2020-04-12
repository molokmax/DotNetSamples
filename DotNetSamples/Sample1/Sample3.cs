using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSamples.Sample1
{
    class Sample3 : ISample
    {
        public void Do()
        {
            List<Action> actions = new List<Action>();
            for (int count = 0; count < 10; count++)
            {
                actions.Add(() => Console.Write(count + " "));
            }

            foreach (Action action in actions)
            {
                action();
            }

            Console.WriteLine();

            List<Action> actions2 = new List<Action>();
            for (int count = 0; count < 10; count++)
            {
                actions2.Add(BuildAct(count));
            }
            foreach (Action action in actions2)
            {
                action();
            }
        }

        private Func<int, Action> BuildAct = (i) => { return () => Console.Write(i + " "); };
    }

}
