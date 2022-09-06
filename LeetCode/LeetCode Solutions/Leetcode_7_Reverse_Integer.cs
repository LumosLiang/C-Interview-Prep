
using System.Collections.Generic;
using System;

namespace LeetCode
{
    public class Leetcode_7_Reverse_Integer
    {
        public int Reverse(int x)
        {
            if (x == -Math.Pow(2, 31)) return 0;

            int res = 0, baseNumber = 10, sign = 1;
            if (x < 0) sign = -1;
            x = Math.Abs(x);

            while (x != 0)
            {
                var r = x % 10;
                if (res > int.MaxValue / baseNumber || (res == int.MaxValue / baseNumber && r >= int.MaxValue - res * baseNumber))
                    return 0;

                res = res * baseNumber + r;

                //// check if overflow 1
                //if (temp / 10 != res) return 0;

                x /= 10;
            }
            return res * sign;
        }
    }
}

