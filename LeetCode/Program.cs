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
            LeetCode7Test();
            //LeetCode11Test();
            //LeetCode36Test();
            //LeetCodeTest21();
            //LeetCodeTest53();
            //LeetCodeTest77();
            //LeetCodeTest88();
            //LeetCode98Test();
            //LeetCode118Test();
            //LeetCode145Test();
            //LeetCode509Test();
            //LeetCode557Test();
            //LeetCode242Test();
            //LeetCode567Test();
            //LeetCode653Test();
            //LeetCode733Test();
            //LeetCode746Test();
            //LeetCode207Test();
        }

        private static void LeetCode207Test()
        {
            Leetcode_207_Course_Schedule solution = new Leetcode_207_Course_Schedule();
            int numCourse = 2;
            int[][] prerequisites = new int[][]
            {
                new int[]{1, 0}
            };

            Console.WriteLine(solution.CanFinish(numCourse, prerequisites));
            Console.ReadKey();
        }

        private static void LeetCode653Test()
        {
            TreeSolutions solution = new TreeSolutions();
            TreeNode root = new TreeNode(2, new TreeNode(1), new TreeNode(3));
            var res = solution.FindTarget(root, 1);
        }

        private static void LeetCodeTest77()
        {
            BackTrackSolutions solution = new BackTrackSolutions();
            var res = solution.Combine(4, 2);
            
        }

        private static void LeetCode145Test()
        {
            TreeNode root = new TreeNode(1, null, new TreeNode(2, new TreeNode(3), null));
            TreeSolutions solution = new TreeSolutions();
            var res = solution.PostorderTraversalDFS(root);
        }

        private static void LeetCode733Test()
        {
            int[][] test = new int[2][];
            test[0] = new int[] { 0, 0, 0 };
            test[1] = new int[] { 0, 1, 1 };
            

            Leetcode_733_Flood_Fill solution = new Leetcode_733_Flood_Fill();
            var res = solution.FloodFill(test, 1, 1, 1);
            Console.WriteLine(res);

        }

        private static void LeetCode36Test()
        {

            char[][] test = new char[9][];
            test[0] = new char[] { '.', '.', '4', '.', '.', '.', '6', '3', '.' };
            test[1] = new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' };
            test[2] = new char[] { '5', '.', '.', '.', '.', '.', '.', '9', '.' };
            test[3] = new char[] { '.', '.', '.', '5', '6', '.', '.', '.', '.' };
            test[4] = new char[] { '4', '.', '3', '.', '.', '.', '.', '.', '1' };
            test[5] = new char[] { '.', '.', '.', '7', '.', '.', '.', '.', '.' };
            test[6] = new char[] { '.', '.', '.', '5', '.', '.', '.', '.', '.' };
            test[7] = new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' };
            test[8] = new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' };


            char[,] test1 = new char[9, 9] 
            { 
                { '.', '.', '4', '.', '.', '.', '6', '3', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '5', '.', '.', '.', '.', '.', '.', '9', '.' },
                { '.', '.', '.', '5', '6', '.', '.', '.', '.' },
                { '4', '.', '3', '.', '.', '.', '.', '.', '1' },
                { '.', '.', '.', '7', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '5', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            };
                

            Leetcode_36_Valid_Sudoku solution = new Leetcode_36_Valid_Sudoku();
            var res = solution.IsValidSudoku(test);
            Console.WriteLine(res);
        }

        private static void LeetCode242Test()
        {
            Leetcode_242_Valid_Anagram solution = new Leetcode_242_Valid_Anagram();
            var res = solution.IsAnagram("anagram", "nagaram");
        }

        private static void LeetCode567Test()
        {
            Leetcode_567_Permutation_in_String solution = new Leetcode_567_Permutation_in_String();
            var res = solution.CheckInclusion("adc", "dcda");
        }

        private static void LeetCode746Test()
        {
            Leetcode_746_Min_Cost_Climbing_Stairs solution = new Leetcode_746_Min_Cost_Climbing_Stairs();
            var res = solution.MinCostClimbingStairs(new int[] { 10, 15}); 
        }

        private static void LeetCode509Test()
        {
            Leetcode_509_Fibonacci_Number solution = new Leetcode_509_Fibonacci_Number();
            var res = solution.Fib(3);

        }

        static void LeetCode118Test()
        {
            Leetcode_118_Pascal_Triangle solution = new Leetcode_118_Pascal_Triangle();
            var res = solution.Generate(3);
            Console.WriteLine(res);
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
            int[] nums = new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            var res = solution.TwoSum(nums, 11);
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
            var res = solution.Reverse(-2147483648);
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
        static void LeetCodeTest21()
        {
            Leetcode_21_Merge_Two_Sorted_Lists solution = new Leetcode_21_Merge_Two_Sorted_Lists();

            ListNode l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode l2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            var res = solution.MergeTwoLists1(l1, l2);
            var res2 = solution.MergeTwoLists2(l1, l2);
            Console.WriteLine(res);

        }

        static void LeetCodeTest53()
        {
            Leetcode_53_Maximum_Subarray solution = new Leetcode_53_Maximum_Subarray();
            var res = solution.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            Console.WriteLine(res);

        }

        static void LeetCodeTest88()
        {
            Leetcode_88_Merge_Sorted_Array solution = new Leetcode_88_Merge_Sorted_Array();
            solution.Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
        }

        static void LeetCode98Test()
        {
            Leetcode_98_Validate_Binary_Search_Tree solution = new Leetcode_98_Validate_Binary_Search_Tree();

            TreeNode input = new TreeNode(2, new TreeNode(2), new TreeNode(2));
            var res = solution.IsValidBST(input);
            Console.WriteLine(res);

        }

        static void LeetCode557Test()
        {
            Leetcode_557_Reverse_Words_in_a_String_III solution = new Leetcode_557_Reverse_Words_in_a_String_III();

            var res = solution.ReverseWords("Let's take LeetCode contest");
            Console.WriteLine(res);

        }
    }
}
