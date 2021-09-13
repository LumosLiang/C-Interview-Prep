
using System.Collections.Generic;
using System;

namespace LeetCode
{
    public class Leetcode_11_Container_With_Most_Water
    {
        public int MaxArea(int[] height)
        {
            int left = 0, right = height.Length - 1, res = 0;

            while (left <= right)
            {
                res = Math.Max(res, Math.Min(height[left], height[right]) * (right - left));
                
                if (height[left] <= height[right]) left++;
                else right--;
            }

            return res;
        }
    }
}

