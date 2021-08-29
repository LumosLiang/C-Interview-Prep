using System.Linq;
using System;

namespace LeetCode
{
    public class Leetcode_1672_Richest_Customer_Wealth

    {
        public int MaximumWealth(int[][] accounts)
        {

            int res = int.MinValue;
            foreach (int[] account in accounts)
            {
                int temp = account.Sum();
                res = Math.Max(temp, res);
            }

            return res;
        }
    }
}