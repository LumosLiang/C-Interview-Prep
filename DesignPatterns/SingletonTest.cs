using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatterns
{


    public class SingletonTest
    {
    }


    public class Database {

        // musst be static, because this belong to this Type, not the instance
        private static Database DatabaseInstance;

        // create a lock for multiple threading
        private static readonly Object o = new object();

        // default constructor make it private
        private Database(){
            Console.WriteLine("Connecting to the Database");
        }

        public Database GetInstance()
        {
            // first condition, for speed
            if (DatabaseInstance is null)
            {
                lock (o)
                {
                    // avoid other thread create a instance again.
                    if (DatabaseInstance is null)
                    {
                        DatabaseInstance = new Database();
                    }
                }
            }
            return DatabaseInstance;
        }
    }
}
