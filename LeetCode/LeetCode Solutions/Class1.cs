using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode_Solutions
{
    class Class1
    {
    }

    public class kvPairComparer : IComparer<(string key, int val)>
    {
        public int Compare((string key, int val) c1, (string key, int val) c2)
        {
            if (c1.val == c2.val)
                return c1.key.CompareTo(c2.key);
            else
                return c1.val.CompareTo(c2.val);
        }
    }

}
