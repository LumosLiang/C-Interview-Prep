using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Design_Type.Parameter
{
    class VarTest
    {
        private static void ImplicitlyTypedLocalVariables()
        {
            var name = "Jeff";
            ShowVariableType(name);    // Displays: System.String

            //var n = null;            // Error
            var x = (Exception)null;   // OK, but not much value
            ShowVariableType(x);       // Displays: System.Exception

            var numbers = new Int32[] { 1, 2, 3, 4 };
            ShowVariableType(numbers); // Displays: System.Int32[]

            // Less typing for complex types
            var collection = new Dictionary<String, Single>() { { ".NET", 4.0f } };

            // Displays: System.Collections.Generic.Dictionary`2[System.String,System.Single]
            ShowVariableType(collection);

            foreach (var item in collection)
            {
                // Displays: System.Collections.Generic.KeyValuePair`2[System.String,System.Single]
                ShowVariableType(item);
            }
        }

        // Generics
        private static void ShowVariableType<T>(T t) 
        { 
            Console.WriteLine(typeof(T)); 
        }
    }

}
