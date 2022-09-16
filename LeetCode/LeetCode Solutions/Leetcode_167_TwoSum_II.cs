
using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_167_TwoSum_II
    {
        public int[] TwoSum(int[] numbers, int target)
        {

            int l = 0, r = numbers.Length - 1;
            while (l <= r)
            {
                int sum = numbers[l] + numbers[r];
                if (sum == target) return new int[] { l + 1, r + 1 };
                else if (sum > target) r--;
                else l++;
            }

            return new int[2];

        }
    }
}

