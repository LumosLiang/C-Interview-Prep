
using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_1_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> hash = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (hash.ContainsKey(nums[i]))
                {
                    return new int[] { i, hash[nums[i]] };
                }
                else
                {
                    if (!hash.ContainsKey(target - nums[i])) hash.Add(target - nums[i], i);
                }
            }
            return new int[2];
        }
    }
}

