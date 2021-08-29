namespace LeetCode
{
    public class Leetcode_34_Find_First_and_Last_Position_of_Element_in_Sorted_Array
    {
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0) return new int[] { -1, -1 };

            var lo1 = 0;
            var hi1 = nums.Length - 1;
            var res = new int[] { -1, -1 };

            while (lo1 <= hi1)
            {
                var mid = lo1 + (hi1 - lo1) / 2;
                if (nums[mid] >= target) hi1 = mid - 1;
                else lo1 = mid + 1;
            }

            if (lo1 >= nums.Length || nums[lo1] != target) return res;
            else res[0] = lo1;

            var lo2 = 0;
            var hi2 = nums.Length - 1;
            while (lo2 <= hi2)
            {
                var mid = lo2 + (hi2 - lo2) / 2;
                if (nums[mid] > target) hi2 = mid - 1;
                else lo2 = mid + 1;
            }

            res[1] = lo2 - 1;
            return res;
        }
    }

}
