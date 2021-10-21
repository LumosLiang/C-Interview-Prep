
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_977_Squares_of_a_Sorted_Array
    {
        public int[] SortedSquares(int[] nums)
        {
            int len = nums.Length;
            int[] res = new int[len];
            int l = 0, r = len - 1, idx = len - 1;

            while (l <= r)
            {
                int left = nums[l] * nums[l], right = nums[r] * nums[r];
                if (left <= right)
                {
                    res[idx] = right;
                    r--;
                }
                else
                {
                    res[idx] = left;
                    l++;
                }
                idx--;
            }

            return res;
        }
    }
}

