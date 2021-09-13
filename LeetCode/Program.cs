using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.LeetCode_Solutions;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region Leetcode
            LeetCodeTest();
            #endregion

            #region sort
            //SortTest();
            #endregion
        }

        static void LeetCodeTest()
        {

            //LeetCode1Test();
            //LeetCode2Test();
            //LeetCode3Test();
            //LeetCode4Test();
            //LeetCode5Test();
            //LeetCode6Test();
            //LeetCode7Test();
            LeetCode11Test();
        }

        static void SortTest()
        {
            var srt = new Sort();
            List<int> nums = new List<int> { 43,1,5,75,87,3,7,56,12,15,99,22,66};

            //srt.BubbleSort(nums);
            //srt.SelectionSort(nums);
            //srt.InsertionSort(nums);
            nums = srt.MergeSort(nums);
            srt.QuickSort(nums);
            Console.WriteLine(nums);
        }


        static void LeetCode1Test()
        {
            Leetcode_1_TwoSum solution = new Leetcode_1_TwoSum();
            int[] nums = new int[] { 2, 7, 11, 15 };
            var res = solution.TwoSum(nums, 9);
            Console.WriteLine(res);

        }

        static void LeetCode2Test()
        {
            Leetcode_2_Add_Two_Numbers solution = new Leetcode_2_Add_Two_Numbers();
            // [2 -> 4 -> 3] [5 -> 6 -> 4]
            var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
           
            var res = solution.AddTwoNumbers(l1, l2);
            Console.WriteLine(res);
 
        }

        static void LeetCode3Test()
        {
            Leetcode_3_Longest_Substring_Without_Repeating_Characters solution = new Leetcode_3_Longest_Substring_Without_Repeating_Characters();
           
            var res = solution.LengthOfLongestSubstring("abba");
            
            Console.WriteLine(res);

        }

        static void LeetCode4Test()
        {
           

        }

        static void LeetCode5Test()
        {
            Leetcode_5_Longest_Palindromic_Substring solution = new Leetcode_5_Longest_Palindromic_Substring();
         
            var res = solution.LongestPalindrome("babad");
      
            Console.WriteLine(res);

        }

        static void LeetCode6Test()
        {
           
        }

        static void LeetCode7Test()
        {
            Leetcode_7_Reverse_Integer solution = new Leetcode_7_Reverse_Integer();
            var res = solution.Reverse(123);
            Console.WriteLine(res);

        }

        static void LeetCode9Test()
        {
            Leetcode_9_Palindrome_Number solution = new Leetcode_9_Palindrome_Number();
            var res = solution.IsPalindrome(1221);
        }

        static void LeetCode11Test()
        {
            Leetcode_11_Container_With_Most_Water solution = new Leetcode_11_Container_With_Most_Water();
            
            var res = solution.MaxArea(new int[] {1, 8, 6, 2, 5, 4, 8, 3, 7});
            Console.WriteLine(res);

        }

        

        static void LeetCodeTest15()
        {
            Leetcode_15_3Sum solution = new Leetcode_15_3Sum();
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> res = solution.ThreeSum(nums);
            Console.WriteLine(res);

        }
    }
}
