using System;
using System.Threading;

namespace Singleton.Learn.ThreadSafe
{
    class Singleton
    {
        private Singleton() { }

        private static Singleton _instance;

        private static readonly object _lock = new object();

        public string Value { get; set; }

        public static Singleton GetInstance(string value)
        {
            if (_instance is null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton
                        {
                            Value = value
                        };
                    }
                }                
            }
            return _instance;
        }
        
    }


    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused (yay!)",
                "If you see different values, then 2 singletons were created (booo!!)",
                "RESULT:"
            );

            Thread t1 = new Thread(() => TestSingleton("FOO"));

            Thread t2 = new Thread(() => TestSingleton("BAR"));

            
            t1.Start();
            t2.Start();

            
            t2.Join();
            t1.Join();
        }

        public static void TestSingleton(string value) 
        {
            Singleton singleton = Singleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}
