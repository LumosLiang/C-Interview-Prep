using System;

namespace Singleton.Learn.NonThreadSafe
{
    // what is: to hide the constructor, and leave only one door open.
    // This "door" make sure that it always return the only one instance of this class


    // why sealed?
    // private constructor
    public sealed class Singleton
    {
        // make the default constructor private
        private Singleton() { }

        // key1: store the instace in the class directly
        // why? make sure only one and only the same one can be returned
        private static Singleton _instance;

        // key2: get that instance 
        public static Singleton GetInstance() 
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
        public void someBusinessLogic() { }
    }



    class Program 
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed");
            }
        }
    }
}
