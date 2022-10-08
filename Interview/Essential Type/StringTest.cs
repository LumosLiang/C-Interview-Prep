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

        public void StringBuilderInitialize()
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

        internal void StringTypicalMethods()
        {
            string s = "test";

            // indexing and slicing
            Console.WriteLine(s[1]);
            //Console.WriteLine(s[1..]);
            //Console.WriteLine(s[..]);
            //Console.WriteLine(s[2..^s.Length]);
            Console.WriteLine(s.Substring(2));
            Console.WriteLine(s.Substring(2,1));

            // int to string, string to int
            string numString = "123";
            // string to int
            int i = Convert.ToInt32(numString);
            int i1 = Int32.Parse(numString);
            int i2;
            var isCan = Int32.TryParse(numString, out i2);

            // string trim, split
            string test = "   ds af gd sa fa sd s   ";

            Console.WriteLine(test.Split(' '));
            Console.WriteLine(test.Trim());
            Console.WriteLine(test.TrimEnd('e'));
            Console.WriteLine(test.TrimStart('d', 's'));

        }
    }
}
