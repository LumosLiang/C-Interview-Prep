using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Type_Basic
{
    class EqualityIdentityTest
    {
        static void EqualTest()
        {

            double e = 2.718281828459045;
            double d = e;
            object o1 = e;
            object o2 = d;

            // check content, Equality
            Console.WriteLine(o1.Equals(o2));

            // check reference, Identity
            Console.WriteLine(object.ReferenceEquals(o1, o2));

            // check reference, can be identity or Equality?
            Console.WriteLine(o1 == o2);

        }
    }
}
