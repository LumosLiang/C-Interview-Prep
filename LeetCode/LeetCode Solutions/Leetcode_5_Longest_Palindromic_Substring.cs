
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_5_Longest_Palindromic_Substring
    {
        public string LongestPalindrome(string s)
        {

            var res = "";

            for (int i = 0; i < s.Length - 1; i++)
            {
                // same start
                var odd = Helper(s, i, i);
                if (odd.Length > res.Length) res = odd;
                // adjcent
                var even = Helper(s, i, i + 1);
                if (even.Length > res.Length) res = even;
            }

            return res;

        }

        public string Helper(string s, int l, int r)
        {
            while (l >= 0 && r <= s.Length - 1)
            {
                if (s[l] == s[r])
                {
                    l--;
                    r++;
                }
                else break;
            }

            return s.Substring(l + 1, (r - 1) - (l + 1) + 1);
        }
    }
}

