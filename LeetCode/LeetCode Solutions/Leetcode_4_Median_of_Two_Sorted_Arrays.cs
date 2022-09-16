using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Leetcode_4_Median_of_Two_Sorted_Arrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

            //int l1 = nums1.Length, l2 = nums2.Length;

            //if ((l1 + l2) % 2 == 1)
            //    return Helper(nums1, nums2, (l1 + l2) / 2);
            //else
            //    return (Helper(nums1, nums2, (l1 + l2) / 2) + Helper(nums1, nums2, (l1 + l2) / 2 - 1)) / 2;
            return 0;
        }

        // help me return the kth(idx) point of two arrays
        //public double Helper(int[] nums1, int[] nums2, int k)
        //{

        //    if (nums1.Length == 0) return nums2[k];

        //    else if (nums2.Length == 0) return nums1[k];

        //    int l1 = 0, l2 = 0, r1 = nums1.Length - 1, r2 = nums2.Length - 1;

        //    int m1 = l1 + (r1 - l1) / 2, m2 = l2 + (r2 - l2) / 2;

        //    if (m1 + m2 < k)
        //    {
        //        if (nums1[m1] < nums2[m2])
        //            return Helper(nums1[(m1 + 1)..^0], nums2, k - m1 - 1);
        //        else
        //            return Helper(nums1, nums2[(m2 + 1)..^0], k - m2 - 1);
        //    }

        //    else
        //    {
        //        if (nums1[m1] < nums2[m2])
        //            return Helper(nums1, nums2[0..m2], k);
        //        else
        //            return Helper(nums1[0..m1], nums2, k);
        //    }
        //}
    }
}
