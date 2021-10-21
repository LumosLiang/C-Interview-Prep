using System.Linq;

namespace LeetCode
{
    public class Leetcode_88_Merge_Sorted_Array
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int n1 = m - 1, n2 = n - 1, idx = m + n - 1;

            while (n1 >= 0 && n2 > 0)
            {
                if (nums1[n1] >= nums2[n2])
                {
                    nums1[idx] = nums1[n1];
                    n1--;
                }
                else
                {
                    nums1[idx] = nums2[n2];
                    n2--;
                }
                idx--;
            }
            return;
        }
    }
}