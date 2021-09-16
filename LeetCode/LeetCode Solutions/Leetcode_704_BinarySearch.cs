namespace LeetCode
{
    public class Leetcode_704_Binary_Search
    {
        public int Search(int[] nums, int target)
        {

            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] > target) right = mid - 1;
                else left = mid + 1;
            }

            return -1;
        }

        public int Search2(int[] nums, int target)
        {

            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;

                // search the 
                if (nums[mid] >= target) right = mid;
                else left = mid + 1;
            }
            if (nums[left] != target) return -1;
            else return left;
        }
    }
}