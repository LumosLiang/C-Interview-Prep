using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class StringTest
    {
        public void StringInitialize()
        {
            // Initialize a string

            string s = "test";
            Console.WriteLine(s);

            s += "ABC";
            Console.WriteLine(s);

        }

        internal void StringBuilderInitialize()
        {
            // initialize a string using string builder
            StringBuilder sb = new StringBuilder("ABC", 50);
            var sb2 = new StringBuilder(20);
            var empt = String.Empty;

            StringBuilder sb3 = sb;
            sb3.Append("for StringBuilder");

            StringBuilder sb4 = new StringBuilder("This is a test", 2, 5, 50);

            Console.WriteLine(sb4);
            Console.WriteLine(ReferenceEquals(sb3, sb));
            Console.ReadLine();
        }

    }
}
