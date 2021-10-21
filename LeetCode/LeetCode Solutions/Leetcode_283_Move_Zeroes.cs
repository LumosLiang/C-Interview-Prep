
using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_283_Move_Zeroes
    {
        public void MoveZeroes(int[] nums)
        {
            int slow = 0, fast = 0;
            while (fast < nums.Length)
            {
                if (nums[fast] != 0)
                {
                    nums[slow] = nums[fast];
                    slow++;
                }
                fast++;
            }
            while (slow < nums.Length)
            {
                nums[slow] = 0;
                slow++;
            }
        }

        public void MoveZeroes2(int[] nums)
        {
            int slow = 0;
            for (int fast = 0; fast < nums.Length; fast++)
            {
                if (nums[fast] != 0)
                {
                    int temp = nums[slow];
                    nums[slow] = nums[fast];
                    nums[fast] = temp;
                    slow++;
                }
                
            }
        }
    }
}

