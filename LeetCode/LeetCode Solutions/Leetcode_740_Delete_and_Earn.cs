
using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_740_Delete_and_Earn
    {
        public int DeleteAndEarn(int[] nums)
        {
            if (nums.Length == 1) return nums[0];

            int[] points = new int[10000],
                  dp = new int[10000];

            foreach (int num in nums)
            {
                points[num] += num;
            }

            dp[0] = nums[0];
            dp[1] = Math.Max(dp[0], nums[1]);

            for (int i = 2; i < nums.Length; i++)
            {
                dp[i] = Math.Max(nums[i] + dp[i - 2], dp[i - 1]);
            }

            return dp[nums.Length - 1];

        }
    }
}

