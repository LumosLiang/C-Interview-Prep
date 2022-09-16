using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode_Solutions
{
    class Leetcode_454_4Sum_II
    {
        public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
        {
            Dictionary<int, int> hash = new Dictionary<int, int>();
            int res = 0;

            foreach (var num1 in nums1)
            {
                foreach (var num2 in nums2)
                {
                    int k = 0 - (num1 + num2);
                    if (!hash.ContainsKey(k))
                    {
                        hash[k] = 1;
                    }
                    else
                        hash[k]++;
                }
            }


            foreach (var num3 in nums3)
            {
                foreach (var num4 in nums4)
                {
                    int k = num3 + num4;
                    if (hash.ContainsKey(k))
                    {
                        res += hash[k]; 
                    }
                }
            }

            return res;
           
        }
    }
}
