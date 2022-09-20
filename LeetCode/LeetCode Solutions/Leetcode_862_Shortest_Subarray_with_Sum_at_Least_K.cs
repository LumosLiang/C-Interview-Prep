using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode_Solutions
{
    class Leetcode_862_Shortest_Subarray_with_Sum_at_Least_K
    {
        public int ShortestSubarray(int[] nums, int k)
        {

            long currSum = 0;
            int res = nums.Length + 1;

            var dq = new LinkedList<(int idx, long s)>();
            dq.AddFirst((-1, 0));

            for (int i = 0; i < nums.Length; i++)
            {
                currSum += nums[i];

                while (dq.Count > 0 && currSum <= dq.Last.Value.Item2)
                {
                    dq.RemoveLast();
                }
                dq.AddLast((i, currSum));

                while (dq.Count > 0 && currSum - dq.First.Value.Item2 >= k)
                {
                    // Console.WriteLine((currSum, dq.First.Value.Item2));
                    res = Math.Min(res, i - dq.First.Value.Item1);
                    dq.RemoveFirst();
                }

            }
            return res == nums.Length + 1 ? -1 : res;

        }
    }
}
