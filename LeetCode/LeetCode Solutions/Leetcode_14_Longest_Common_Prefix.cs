
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_14_Longest_Common_Prefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1) return strs[0];

            var res = "";
            int p = 0;
            while (IsEqual(strs, p))
            {
                res += strs[0][p];
                p += 1;
            }
            return res;
        }

        private bool IsEqual(string[] strs, int p)
        {
            var res = true;

            for (int i = 0; i < strs.Length - 1; i++)
            {
                if (strs[i].Substring(p, strs[i].Length - p) != "" && strs[i + 1].Substring(p, strs[i].Length - p) != "" && strs[i][p] == strs[i + 1][p])
                {
                    continue;
                }
                else return false;
            }

            return res;
        }
    }
}

