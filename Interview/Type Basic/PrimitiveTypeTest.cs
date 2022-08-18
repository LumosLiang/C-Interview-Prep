using System;


namespace Interview.Type.Basic
{

    class PrimitiveTypeTest
    {
        //Another way to think of this is that the C# compiler automatically assumes
        //that you have the following using directives 

        //using sbyte = System.SByte; 
        //using byte = System.Byte; 
        //using short = System.Int16; 
        //using ushort = System.UInt16; 
        //using int = System.Int32; 
        //using uint = System.UInt32;

        public void Initialize()
        {
            // different ways to initialize
            System.Int32 a = new System.Int32();
            int c = new int();
            int b = 32;

            Console.WriteLine((a, c));
            Console.WriteLine(b);

            char s = 't';
            Console.WriteLine(s);

        }
    }
}



