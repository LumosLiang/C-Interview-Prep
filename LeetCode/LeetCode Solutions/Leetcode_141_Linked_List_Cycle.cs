
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_141_Linked_List_Cycle
    {
        public bool HasCycle(ListNode head)
        {
            ListNode slow = head, fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast) return true;
            }

            return false;
        }
    }
}
