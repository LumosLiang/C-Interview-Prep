
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_35_Search_Insert_Position
    {
        public int SearchInsert(int[] nums, int target)
        {
            var lo = 0;
            var hi = nums.Length - 1;

            while (lo <= hi)
            {
                var mid = lo + (hi - lo) / 2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] > target) hi = mid - 1;
                else lo = mid + 1;
            }
            return lo;
        }

        public int SearchInsert2(int[] nums, int target)
        {

            int l = 0, r = nums.Length;

            while (l < r)
            {
                int mid = l + (r - l) / 2;
                if (nums[mid] < target) l = mid + 1;
                else r = mid;
            }

            return l;
        }
    }
}

