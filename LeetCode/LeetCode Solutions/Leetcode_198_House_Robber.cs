
using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_198_House_Robber
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 1) return nums[0];

            int[] dp = new int[nums.Length];
            dp[0] = nums[0];
            dp[1] = Math.Max(dp[0], nums[1]);

            for (int i = 2; i < nums.Length; i++)
            {
                dp[i] = Math.Max(nums[i] + dp[i - 2], dp[i - 1]);
            }

            return dp[nums.Length - 1];
        }

        public int Rob2(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            if (nums.Length == 2) return Math.Max(nums[0], nums[1]);

            int prepre = nums[0],
                pre = Math.Max(prepre, nums[1]),
                curr = 0;

            for (int i = 2; i < nums.Length; i++)
            {
                curr = Math.Max(nums[i] + prepre, pre);
                prepre = pre;
                pre = curr;
            }

            return curr;
        }
    }
}

