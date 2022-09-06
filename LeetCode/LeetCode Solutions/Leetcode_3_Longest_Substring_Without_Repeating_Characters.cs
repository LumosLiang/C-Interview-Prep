
using System.Collections.Generic;
using System;

namespace LeetCode
{
    public class Leetcode_3_Longest_Substring_Without_Repeating_Characters
    {
        public int LengthOfLongestSubstring(string s)
        {
            int left = 0, res = 0;
            Dictionary<int, int> window = new Dictionary<int, int>();

            for (int right = 0; right < s.Length; right++) 
            {
                if (window.ContainsKey(s[right]))
                {
                    left = Math.Max(left, window[s[right]] + 1);
                }

                window[s[right]] = right;
                res = Math.Max(res, right - left + 1);
            }
            return res;
        }

        // more readable
        public int LengthOfLongestSubstring2(string s)
        {
            int left = 0, right = 0, res = 0;
            Dictionary<int, int> window = new Dictionary<int, int>();
            while (right < s.Length)
            {
                if (window.ContainsKey(s[right])) window[s[right]] += 1;
                else window.Add(s[right], 1);

                while (window[s[right]] > 1)
                {
                    window[s[left]] -= 1;
                    left++;
                }
                res = Math.Max(res, right - left + 1);
                right++;
            }
            return res;
        }
    }
}

