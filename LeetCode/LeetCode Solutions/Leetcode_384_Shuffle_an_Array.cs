using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode_Solutions
{
    class Leetcode_384_Shuffle_an_Array
    {
        public class Solution
        {
            public readonly int[] originalNums;
            public readonly int[] currNums;
            public Random picker;

            public Solution(int[] nums)
            {
                originalNums = nums;
                currNums = (int[])nums.Clone();
                picker = new Random();
            }

            public int[] Reset()
            {
                return originalNums;
            }

            public int[] Shuffle()
            {
                for (int i = currNums.Length - 1; i > -1; i--)
                {

                    var pick = picker.Next(i + 1);

                    var temp = currNums[i];
                    currNums[i] = currNums[pick];
                    currNums[pick] = temp;
                }

                return currNums;
            }

        }

    }
}
