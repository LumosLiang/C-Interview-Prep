using System;

namespace LeetCode
{
    public class Leetcode_209_Minimum_Size_Subarray_Sum
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            var l = 0;
            var rsum = 0;
            int res = int.MaxValue;

            for (int r = 0; r < nums.Length; r++)
            {
                rsum += nums[r];
                while (rsum >= target)
                {
                    res = Math.Min(res, r - l + 1);
                    rsum -= nums[l];
                    l += 1;
                }
            }

            if (res == int.MaxValue) return 0;
            return res;
        }
    }
}