using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Leetcode_239_Sliding_Window_Maximum

    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {

            //         int l = 0;
            //         var res = new List<int>();

            //         for(int r = 0; r < nums.Length + 1; r++)
            //         {
            //             if(r - l == k)
            //             {
            //                 res.Add(nums[l..r].Max());
            //                 l++;
            //             }
            //         }

            //         return res.ToArray();




            //int l = 0;
            var res = new List<int>();
            //var pq = new PriorityQueue<(int idx, int num), int>();

            //for (int r = 0; r < nums.Length; r++)
            //{
            //    pq.Enqueue((r, nums[r]), -nums[r]);

            //    if (r - l == k - 1)
            //    {

            //        res.Add(pq.Peek().Item2);
            //        l++;

            //        while (pq.Count != 0 && pq.Peek().Item1 < l)
            //            pq.Dequeue();

            //    }
            //}

            return res.ToArray();

        }
    }
}
