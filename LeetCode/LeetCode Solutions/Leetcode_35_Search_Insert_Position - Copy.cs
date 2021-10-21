
using System.Collections.Generic;
using System;

namespace LeetCode
{
    public class Leetcode_350_Intersection_of_Two_Arrays_II
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);

            var res = new List<int>();
            int n1 = 0, n2 = 0;

            while (n1 < nums1.Length && n2 < nums2.Length)
            {
                if (nums1[n1] == nums2[n2])
                {
                    res.Add(nums1[n1]);
                    n1++;
                    n2++;
                }
                else if (nums1[n1] > nums2[n2]) n2++;
                else n1++;
            }

            return res.ToArray();
        }
    }
}

