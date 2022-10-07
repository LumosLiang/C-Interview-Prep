using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode_Solutions
{

    // 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15

    public class Leetcode_172_Factorial_Trailing_Zeroes
    {
        public int TrailingZeroes(int n)
        {
            int res = 0;

            for (int i = 1; i <= n; i++)
            {
                int temp = i;
                while (temp % 5 == 0)
                {
                    temp /= 5;
                    res++;
                }
            }
            return res;
        }
    }
}
