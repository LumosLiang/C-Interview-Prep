using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_19_Remove_Nth_Node_From_End_of_List
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {


            ListNode newhead = new ListNode(0, head);

            ListNode slow = newhead, fast = newhead;

            int cnt = 0;
            while (cnt < n)
            {
                fast = fast.next;
                cnt++;
            }

            while (fast.next != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            slow.next = slow.next.next;

            return newhead.next;

        }

    }
}

