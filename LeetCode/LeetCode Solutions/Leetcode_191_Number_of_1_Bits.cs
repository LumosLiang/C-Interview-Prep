using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode_Solutions
{
    class Leetcode_191_Number_of_1_Bits
    {
        int res = 0;
        
        while(n != 0)
        {
            n = n & (n - 1);
            res++;
        }
        
        return res;

    }
}
