using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_153_Find_Minimum_in_Rotated_Sorted_Array
    {
        public int FindMin(int[] nums)
        {

            int l = 0, r = nums.Length - 1;

            while (l < r)
            {
                int mid = l + (r - l) / 2;

                if (nums[mid] > nums[r])
                    l = mid + 1;
                else
                    r = mid;

            }

            return nums[l];

        }
    }
}

