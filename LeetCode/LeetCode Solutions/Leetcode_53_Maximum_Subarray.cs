
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Leetcode_53_Maximum_Subarray

    {
        public int MaxSubArray(int[] nums)
        {

            return Helper(nums, 0, nums.Length - 1);

        }

        private int Helper(int[] nums, int start, int end)
        {
            if (start > end) return -20000;
            if (start == end) return nums[start];

            int mid = start + (end - start) / 2;

            int left = Helper(nums, start, mid - 1);
            int right = Helper(nums, mid + 1, end);
            int middle = CalcMidSub(nums, mid, start, end);

            return Enumerable.Max(new int[] { left, right, middle});

        }

        public int CalcMidSub(int[] nums, int mid, int start, int end)
        {
            int res = nums[mid];

            int rmax = -20000, rrsum = 0, lmax = -20000, lrsum = 0;

            for (int i = mid + 1; i <= end; i++)
            {
                rrsum += nums[i];
                rmax = Math.Max(rmax, rrsum);
            }

            for (int j = mid - 1; j >= start; j--)
            {
                lrsum += nums[j];
                lmax = Math.Max(lmax, lrsum);
            }

            return Enumerable.Max(new int[] { res, res + rmax, res + lmax, res + lmax + rmax });
        }

    }
}

