
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_14_Longest_Common_Prefix
    {
        public string LongestCommonPrefix(string[] strs)
        {

            var res = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                res = GetCommon(res, strs[i]);
            }

            return res;
        }

        private static string GetCommon(string string1, string string2)
        {
            int p1 = 0, p2 = 0;
            string res = "";
            while (p1 < string1.Length && p2 < string2.Length)
            {
                if (string1[p1] == string2[p2])
                {
                    res += string1[p1];
                    p1++;
                    p2++;
                }
                else break;
            }
            return res;
        }
    }
}

