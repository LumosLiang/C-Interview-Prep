using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Design_Type.Generics
{
    internal sealed class DictionaryStringKey<T>: Dictionary<String, T>
    {
    }

    public static class GenericOpenCloseTest {

        public static void Go() {

            Object o = null;
            System.Type t = typeof(Dictionary<,>);

            o = CreateInstance(t);
            Console.WriteLine();

            t = typeof(DictionaryStringKey<>);

            o = CreateInstance(t);
            Console.WriteLine();

            t = typeof(DictionaryStringKey<int>);

            o = CreateInstance(t);
            Console.WriteLine();

        }



        private static Object CreateInstance(System.Type t)
        {
        
            Object o = null;
            try
            {
                o = Activator.CreateInstance(t);
                Console.Write("Created instance of {0}", t.ToString());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            return o;
        }
    } 

}
