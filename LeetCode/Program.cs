using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Leetcode
            LeetCodeTest();
            #endregion

        }

        static void LeetCodeTest()
        {
            //LeetCodeTest15();
            LeetCodeTest1();
        }

        static void LeetCodeTest15()
        {
            Leetcode_15_3Sum solution = new Leetcode_15_3Sum();
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> res = solution.ThreeSum(nums);
            Console.WriteLine(res);

        }

        static void LeetCodeTest1()
        {
            Leetcode_1_TwoSum solution = new Leetcode_1_TwoSum();
            int[] nums = new int[] { 2, 7, 11, 15 };
            var res = solution.TwoSum(nums, 9);
            Console.WriteLine(res);

        }

    }
}
