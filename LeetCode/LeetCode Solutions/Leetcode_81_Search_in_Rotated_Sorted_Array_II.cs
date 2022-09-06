

namespace LeetCode
{
    public class Leetcode_81_Search_in_Rotated_Sorted_Array_II
    {
        public bool Search(int[] nums, int target)
        {

            var l = 0;
            var r = nums.Length - 1;

            while (l < r)
            {

                while (l + 1 < r && nums[l + 1] == nums[l]) l++;

                var mid = l + (r - l) / 2;
                if (nums[mid] == target) return true;

                if (nums[mid] > nums[r] && target <= nums[r]) l = mid + 1;
                else if (target > nums[r] && nums[mid] <= nums[r]) r = mid - 1;
                else
                {
                    if (nums[mid] < target) l = mid + 1;
                    else r = mid;
                }

            }
            if (nums[l] == target) return true;
            else return false;
        }
    }


}
