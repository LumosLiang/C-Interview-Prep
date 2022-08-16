using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Design_Type.Method

{

    // This part is used to test constructor chaining and static constructor
    // why?
    class RefTypeConstrChaininfg
    {
        internal string Name;
        internal int Id;

        internal RefTypeConstrChaininfg() : this(string.Empty)
        {
            Console.WriteLine("chaining 1");
        }

        internal RefTypeConstrChaininfg(string name) : this(name, 0)
        {
            Console.WriteLine("chaining 2");
        }

        internal RefTypeConstrChaininfg(string name, int id)
        {
            Name = name;
            Id = id;
            Console.WriteLine("chaining 3");
        }
    }

    internal sealed class SomeType
    {
        private Int32 m_x;
        private String m_s;
        private Double m_d;
        private Byte m_b;

        public SomeType()
        {
            m_x = 5;
            m_s = "Hi there";
            m_d = 3.14159;
            m_b = 0xff;
        }

        public SomeType(string s): this()
        { 
        }

        public SomeType(int i, string s): this(s)
        { 
        }
    }
}
