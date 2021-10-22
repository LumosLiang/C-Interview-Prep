using System.Collections.Generic;
using System.Text;
namespace LeetCode
{
    public class Leetcode_509_Fibonacci_Number
    {
        public int Fib(int n)
        {

            if (n < 2) return n;

            //List<int> dp = new List<int>(new int[n + 1]);
            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }
    }
}
