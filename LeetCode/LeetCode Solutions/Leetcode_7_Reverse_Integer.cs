
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_7_Reverse_Integer
    {
        public int Reverse(int x)
        {
            int res = 0;
            while (x != 0)
            {
                int temp = res * 10 + x % 10;
                // check if overflow
                if (temp / 10 != res) return 0;
                res = temp;
                x /= 10;
            }
            return res;
        }
    }
}

