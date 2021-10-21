
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_217_Contains_Duplicate

    {

        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            return nums.Length == set.Count;
        }

        public bool ContainsDuplicate2(int[] nums)
        {
            List<int> l = new List<int>(nums);
            l.Sort();
            for (int i = 0; i < l.Count - 1; i++)
            {
                if (l[i] == l[i + 1]) return true;
            }
            return false;
        }

    }
}

