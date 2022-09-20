using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Design_Type.Type_and_Member_Basics
{
    class CallandCallvirTest
    {
        public static void Go()
        {
            Console.WriteLine();            // Call a static method

            Object o = new Object();
            o.GetHashCode();                // Call a virtual instance method
            o.GetType();                    // Call a nonvirtual instance method
        }

    }
}
