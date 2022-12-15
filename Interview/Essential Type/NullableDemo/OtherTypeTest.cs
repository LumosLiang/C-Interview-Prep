using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Interview.Essential_Type.NullableDemo
{

    class OtherTypeTest
    {
        internal void DefaultInitialize()
        {
            throw new NotImplementedException();
        }


        internal void NullableInitialize()
        {
            // nullable type

            int? nulltest = null;
            Console.WriteLine(nulltest);

        }
    }
}



