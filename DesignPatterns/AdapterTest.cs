using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class AdapterTest
    {
        public static void Go()
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());
        }

    }

    // interface used by the client code(main logic)
    public interface ITarget {

        string GetRequest();
    }

    // some third party app or libraray or class
    // but its interface is incompatible with the existing client code. The Adaptee needs some
    // adaptation before the client code can use it
    class Adaptee
    {
        public int GetSpecificRequest() {

            return 255;
        }
    }

    // The Adapter makes the Adaptee's interface compatible with the Target's
    // interface.
    class Adapter : ITarget
    {

        private readonly Adaptee _adaptee;

        // The Adapter makes the Adaptee's interface compatible with the Target's
        // interface.
        public string GetRequest()
        {
            return $"This is '{this._adaptee.GetSpecificRequest()}'";        
        }

        public Adapter(Adaptee adaptee) 
        {
            _adaptee = adaptee;
        }
        
    }




}
