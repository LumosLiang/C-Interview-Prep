using System.Linq;

namespace LeetCode
{
    public class Leetcode_136_SingleNumbers
    {
        public int SingleNumber(int[] nums)
        {
            var res = 0;
            for (int i = 0; i < nums.Count(); i++) res ^= nums[i];
            return res;
        }
    }
}