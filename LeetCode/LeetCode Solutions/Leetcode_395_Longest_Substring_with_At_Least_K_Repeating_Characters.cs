using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode_Solutions
{
    class Leetcode_395_Longest_Substring_with_At_Least_K_Repeating_Characters
    {
        public int LongestSubstring(string s, int k)
        {

            int res = 0;

            // Longest Substring with i distinct character with at Least K Repeating Characters
            for (int i = 1; i <= 26; i++)
            {
                Dictionary<int, int> hash = new Dictionary<int, int>();
                int temp = 0, l = 0, matchCnt = 0;

                for (int r = 0; r < s.Length; r++)
                {
                    int val = s[r];

                    if (hash.ContainsKey(val)) hash[val]++;
                    else hash[val] = 1;

                    if (hash[val] == k)
                        matchCnt += 1;

                    while (hash.Count > i)
                    {
                        if (hash[s[l]] == k)
                            matchCnt -= 1;
                        hash[s[l]]--;
                        if (hash[s[l]] == 0)
                            hash.Remove(s[l]);
                        l++;
                    }

                    if (matchCnt == i)
                        // Console.WriteLine(hash);
                        // Console.WriteLine((r, l));
                        temp = Math.Max(temp, r - l + 1);

                }
                // Console.WriteLine(temp);

                res = Math.Max(res, temp);
            }

            return res;

        }
    }
}
