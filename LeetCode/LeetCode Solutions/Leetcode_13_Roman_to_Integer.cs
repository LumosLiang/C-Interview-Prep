
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_13_Roman_to_Integer
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> table = new Dictionary<char, int>
            {
                {'I',1},
                {'V',5},
                {'X',10},
                {'L',50},
                {'C',100},
                {'D',500},
                {'M',1000}
            };

            int res = 0, over = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                int pre = table[s[i]], lat = table[s[i + 1]];

                if (pre < lat)
                {
                    over += pre * 2;
                }
                res += pre;
            }

            return res + table[s[-1]] - over;
        }
    }
}

