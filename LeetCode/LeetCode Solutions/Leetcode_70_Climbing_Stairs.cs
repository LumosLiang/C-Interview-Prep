
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_70_Climbing_Stairs
    {
        public int ClimbStairs(int n)
        {
            if (n < 2) return n;

            int[] dp = new int[n];
            dp[0] = 1;
            dp[1] = 2;

            for (int i = 2; i < n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n - 1];

        }

        // dp: reduce dp from O(n) to O(1)
        public int ClimbStairs2(int n)
        {

            if (n <= 2) return n;

            int pre = 2, prepre = 1, res = 0;

            for (int i = 2; i < n; i++)
            {
                res = pre + prepre;
                prepre = pre;
                pre = res;
            }
            return res;
           
        }
        
    }
}

