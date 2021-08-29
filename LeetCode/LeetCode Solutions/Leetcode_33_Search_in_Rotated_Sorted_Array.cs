

namespace LeetCode
{
    public class Leetcode_33_Search_in_Rotated_Sorted_Array

    {
        public int Search(int[] nums, int target)
        {

            var l = 0;
            var r = nums.Length - 1;

            while (l <= r)
            {
                var mid = l + (r - l + 1) / 2;
                if (nums[mid] == target) return mid;
                if (nums[r] >= nums[mid])
                {
                    if (target <= nums[r] && target > nums[mid])
                    {
                        l = mid + 1;
                    }
                    else
                    {
                        r = mid - 1;
                    }
                }
                else
                {
                    if (target >= nums[l] && target < nums[mid])
                    {
                        r = mid - 1;
                    }
                    else
                    {
                        l = mid + 1;
                    }
                }
            }
            return -1;
        }
    }


}
