using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode_Solutions
{
    class LeetCode_287_Find_the_Duplicate_Number
    {
        public int FindDuplicate(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                while (nums[i] != i + 1 && nums[i] <= nums.Length && nums[i] >= 1 && nums[i] != nums[nums[i] - 1])
                {
                    int idx = nums[i] - 1;
                    int temp = nums[idx];
                    nums[idx] = nums[i];
                    nums[i] = temp;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (i + 1 != nums[i]) return nums[i];
            }

            return -1;
        }

    }
}


