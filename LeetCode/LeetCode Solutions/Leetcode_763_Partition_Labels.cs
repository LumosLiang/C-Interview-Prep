using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_763_Partition_Labels
    {
        public IList<int> PartitionLabels(string s)
        {

            Dictionary<char, int> rightmost = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                rightmost[s[i]] = i;
            }

            var left = 0;
            var right = 0;
            IList<int> res = new List<int>();

            for (int j = 0; j < s.Length; j++)
            {
                right = Math.Max(right, rightmost[s[j]]);
                if (j == right)
                {
                    res.Add(right - left + 1);
                    left = right + 1;
                }
            }
            return res;
        }
    }


}
