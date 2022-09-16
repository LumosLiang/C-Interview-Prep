using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode_Solutions
{
    class Leetcode_1358_Number_of_Substrings_Containing_All_Three_Characters
    {
        public int NumberOfSubstrings(string s)
        {

            var hash = new Dictionary<int, int>();
            int l = 0, res = 0;

            for (int r = 0; r < s.Length; r++)
            {
                if (hash.ContainsKey(s[r])) hash[s[r]]++;
                else hash[s[r]] = 1;

                while (hash.Count == 3)
                {
                    hash[s[l]]--;
                    if (hash[s[l]] == 0)
                        hash.Remove(s[l]);
                    l++;
                }

                res += r - l + 1;
            }

            int stringSum = 0;
            for (int i = 1; i < s.Length + 1; i++) stringSum += i;

            return stringSum - res;
        }
    }
}
