
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System;

namespace LeetCode
{
    public class Leetcode_120_Triangle
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            
            int init = triangle[0][0],
                row = triangle.Count;

            if (row == 1) return init;

            List<int> dp = new List<int> { init };

            for (int i = 1; i < row; i++)
            {
                List<int> temp = new List<int>();
                for (int j = 0; j < triangle[i].Count; j++)
                {
                    if (j == 0) temp.Add(dp[0] + triangle[i][j]);
                    else if (j == triangle[i].Count - 1) temp.Add(dp[j - 1] + triangle[i][j]);
                    else temp.Add(Math.Min(dp[j - 1], dp[j]) + triangle[i][j]);
                }
                dp = temp;
            }

            return dp.Min();
        }
    }
}

