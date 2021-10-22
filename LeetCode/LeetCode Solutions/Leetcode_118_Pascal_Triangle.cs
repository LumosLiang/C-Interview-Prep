

using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Leetcode_118_Pascal_Triangle
    {
        public IList<IList<int>> Generate(int numRows)
        {

            List<IList<int>> dp = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                dp.Add(new List<int>(new int[i + 1]));
                dp[i][0] = 1;
                for (int j = 1; j < i; j++)
                {
                    dp[i][j] = dp[i -1 ][j - 1] + dp[i - 1][j];
                }
                dp[i][i] = 1;
            }

            return dp;
        }
    }
}
