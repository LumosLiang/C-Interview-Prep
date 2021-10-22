using System;

namespace LeetCode
{
    public class Leetcode_746_Min_Cost_Climbing_Stairs
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            // dp[n] = cost[n] + min(dp[n - 1], dp[n - 2])
            // base, idx = 0, idx = 1, essentially, like Fibonacci

            int len = cost.Length;
            int[] dp = new int[len + 1];

            for (int i = 0; i <= len; i++)
            {
                if (i < 2) dp[i] = cost[i];
                else if (i < len) dp[i] = cost[i] + Math.Min(dp[i - 1], dp[i - 2]);
                else dp[i] = Math.Min(dp[i - 1], dp[i - 2]);
            }

            return dp[len];
        }
    }
}