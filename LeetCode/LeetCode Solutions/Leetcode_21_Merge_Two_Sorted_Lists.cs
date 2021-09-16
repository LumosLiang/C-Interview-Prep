
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_21_Merge_Two_Sorted_Lists
    {

        public ListNode MergeTwoLists(ListNode A, ListNode B)
        {
            if (A == null) return B;
            if (B == null) return A;

            ListNode dummy = new ListNode(0);
            ListNode currA = A, currB = B, curr = dummy;

            while (currA != null && currB != null)
            {
                if (currA.val <= currB.val)
                {
                    curr.next = new ListNode(currA.val);
                    currA = currA.next;
                }
                else
                {
                    curr.next = new ListNode(currB.val);
                    currB = currB.next;
                }
                curr = curr.next;
            }

            if (currA != null) curr.next = currA;
            else curr.next = currB;

            return dummy.next;
        }
   
    }
}

