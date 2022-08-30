using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Design_Type.InterfaceLearn
{
    internal class Base : IDisposable
    {
        // This method is implicitly sealed and cannot be overridden
        public void Dispose()
        {
            Console.WriteLine("Base's Dispose");
        }
    }

    // This class is derived from Base and it re-implements IDisposable
    internal class Derived : Base, IDisposable
    {
        // This method cannot override Base's Dispose. 'new' is used to indicate 
        // that this method re-implements IDisposable's Dispose method
        new public void Dispose()
        {
            Console.WriteLine("Derived's Dispose");

            // NOTE: The next line shows how to call a base class's implementation (if desired)
            // base.Dispose();
        }
    }


    internal static class InterfaceImplementationVersioningTest
    {
        public static void Go()
        {
            /************************* First Example *************************/
            Base b = new Base();

            // Call's Dispose by using b's type: "Base's Dispose"
            b.Dispose();

            // Call's Dispose by using b's object's type: "Base's Dispose"
            // after all, it is a type.
            ((IDisposable)b).Dispose();


            /************************* Second Example ************************/
            Derived d = new Derived();

            // Call's Dispose by using d's type: "Derived's Dispose"
            d.Dispose();

            // Call's Dispose by using d's object's type: "Derived's Dispose"
            ((IDisposable)d).Dispose();


            /************************* Third Example *************************/
            // base b
            b = new Derived();

            // Call's Dispose by using b's type: "Base's Dispose"
            b.Dispose();

            // Call's Dispose by using b's object's type: "Derived's Dispose"
            ((IDisposable)b).Dispose();
            
        }
    }


}
