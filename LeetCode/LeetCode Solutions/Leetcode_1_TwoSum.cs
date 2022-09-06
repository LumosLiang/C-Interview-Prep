
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
                    if (!hash.ContainsKey(target - nums[i])) 
                        hash.Add(target - nums[i], i);
                }
            }
            return new int[2];
        }


        public int[] TwoSum2(int[] nums, int target)
        {
            Array.Sort(nums);
            int l = 0, r = nums.Length - 1;

            while (l < r)
            {
                int sum = nums[l] + nums[r];
                if (sum == target) return new int[] { l, r };
                else if (sum > target) r--;
                else l++;
            }

            return new int[2];
        }
    }
}

