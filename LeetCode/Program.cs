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
            // LeetCodeTest();
            #endregion

            #region sort
            SortTest();
            #endregion
        }

        static void LeetCodeTest()
        {
            //LeetCodeTest15();
            LeetCodeTest1();
        }

        static void SortTest()
        {
            var srt = new Sort();
            List<int> nums = new List<int> { 43,1,5,75,87,3,7,56,12,15,99,22,66};

            //srt.BubbleSort(nums);
            //srt.SelectionSort(nums);
            //srt.InsertionSort(nums);
            //nums = srt.MergeSort(nums);
            srt.QuickSort(nums);
            Console.WriteLine(nums);
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
