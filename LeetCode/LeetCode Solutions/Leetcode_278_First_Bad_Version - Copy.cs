
using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_268_Missing_Number
    {
        public int MissingNumber(int[] nums)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                while (nums[i] != i && nums[i] <= nums.Length - 1 && nums[i] >= 0 && nums[i] != nums[nums[i]])
                {
                    int idx = nums[i];
                    int temp = nums[idx];
                    nums[idx] = nums[i];
                    nums[i] = temp;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (i != nums[i]) return i;
            }

            return nums.Length;
        }
    }
}

