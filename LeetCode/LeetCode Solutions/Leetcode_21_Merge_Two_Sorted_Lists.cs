
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_21_Merge_Two_Sorted_Lists
    {

        public ListNode MergeTwoLists1(ListNode A, ListNode B)
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

        public ListNode MergeTwoLists2(ListNode A, ListNode B)
        {
            if (A == null) return B;
            if (B == null) return A;

            if (A.val < B.val)
            {
                A.next = MergeTwoLists2(A.next, B);
                return A;
            }
            else
            {
                B.next = MergeTwoLists2(B.next, A);
                return B;
            }
        }

    }
}

