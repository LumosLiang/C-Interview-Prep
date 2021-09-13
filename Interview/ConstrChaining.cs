using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview

{

    // This part is used to test constructor chaining and static constructor
    class ConstrChaining
    {
        internal string Name;
        internal int Id;

        internal ConstrChaining(): this(string.Empty)
        {
            Console.WriteLine("chaining 1");
        }

        internal ConstrChaining(string name): this(name, 0)
        {
            Console.WriteLine("chaining 2");
        }

        internal ConstrChaining(string name, int id)
        {
            Name = name;
            Id = id;
            Console.WriteLine("chaining 3");
        }

    }
}
