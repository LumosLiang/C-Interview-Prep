using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Design_Type.Type_and_Member_Basics
{
    public sealed class SomeType
    {
        // Nested class
        private class SomeNestedType { }

        // Constant, read-only, and static read/write field
        private const Int32 c_SomeConstant = 1;
        private readonly String m_SomeReadOnlyField = "2";
        private static Int32 s_SomeReadWriteField = 3;

        // Type constructor
        static SomeType() { }

        // Instance constructors
        public SomeType(Int32 x) { }
        public SomeType() { }

        // Static and instance methods
        private string InstanceMethod() { return null; }
        public static void GetName() { }

        // Instance property
        public int SomeProp {
            get { return 0; } set { }
        }

        // Instance parameterful property (indexer)
        public int this[string s]
        {
            get { return 0; }
            set { }
        }

        // Instance event
        public event EventHandler SomeEvent;

    }
}
