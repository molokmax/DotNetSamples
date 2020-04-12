using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetSamples.MailCert
{
    class Sample2 : ISample
    {
        public void Do()
        {
            IEnumerable<object> a1 = new string[0];
            // IEnumerable<object> a2 = new int[0];

            Action<string> a3 = new Action<object>(delegate { });
            // Action<int> a4 = new Action<object>(delegate { });
            // Action<object> a5 = new Action<string>(delegate { });

        }
    }
}

