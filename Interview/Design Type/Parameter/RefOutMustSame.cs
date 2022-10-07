using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Design_Type.Parameter
{
    class RefOutMustSame
    {
        public static void Swap(ref Object a, ref Object b)
        {
            Object t = b;
            b = a;
            a = t;
        }

        public static void SomeMethod()
        {
            String s1 = "Jeffrey";
            String s2 = "Richter";
            
            // Swap(ref s1, ref s2);
            Console.WriteLine(s1);  // Displays "Richter"
            Console.WriteLine(s2);  // Displays "Jeffrey"
        }

        public static void SomeMethod2()
        {
            String s1 = "Jeffrey";
            String s2 = "Richter";

            // Variables that are passed by reference 
            // must match what the method expects.
            Object o1 = s1, o2 = s2;
            Swap(ref o1, ref o2);

            // Now cast the objects back to strings.
            s1 = (String)o1;
            s2 = (String)o2;

            Console.WriteLine(s1);  // Displays "Richter"
            Console.WriteLine(s2);  // Displays "Jeffrey"
        }
    }
}
