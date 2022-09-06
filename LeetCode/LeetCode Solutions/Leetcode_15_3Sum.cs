using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_15_3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {

            Array.Sort(nums);
            IList<IList<int>> res = new List<IList<int>>();
            var len = nums.Length;
            if (len < 3) return res;

            for (int i = 0; i < len - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                int l = i + 1;
                int r = len - 1;

                while (l < r)
                {
                    var sum = nums[l] + nums[r] + nums[i];
                    if (sum == 0)
                    {
                        res.Add(new List<int>() { nums[i], nums[l], nums[r] });
                        while (l < r && nums[l] == nums[l + 1]) l++;
                        while (l < r && nums[r] == nums[r - 1]) r--;

                        l += 1;
                        r -= 1;
                    }
                    else if (sum < 0) l++;
                    else r--;
                }
            }
            return res;
        }
    }
}

