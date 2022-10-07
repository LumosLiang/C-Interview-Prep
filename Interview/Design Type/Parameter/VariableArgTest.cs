using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Design_Type.Parameter
{
    class VariableArgTest
    {
        public static Int32 Add(params int[] values)
        {
            var res = 0;
            for (int i = 0; i < values.Length; i++)
            {
                res += values[i];
            }
            return res;
        }

        public int TestVariableArg()
        {
            // return Add(new int[] { 1, 2, 3, 4 });
            return Add(1, 2, 3, 4);
        }
    }
}
