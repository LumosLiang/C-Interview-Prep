using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Leetcode_16_3Sum_Closest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {

            Array.Sort(nums);

            int res = 100000;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                int l = i + 1, r = nums.Length - 1;

                while (l < r)
                {
                    int s = nums[i] + nums[l] + nums[r];

                    if (s == target) return target;

                    else if (Math.Abs(s - target) < Math.Abs(res - target))
                        res = s;

                    else if (s > target)
                        r--;
                    else if (s < target)
                        l++;

                }
            }

            return res;
        }
    }
}
