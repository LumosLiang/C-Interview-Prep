using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode_Solutions
{
    class Leetcode_137_Single_Number_II
    {
        public int SingleNumber(int[] nums)
        {

            int res = 0;

            for (int i = 0; i < 32; i++)
            {
                int temp = 0;
                foreach (var num in nums)
                {
                    if ((num >> i & 1) == 1)
                        temp += 1;
                }

                res += (temp % 3) << i;
            }

            return res;
        }
    }
}
