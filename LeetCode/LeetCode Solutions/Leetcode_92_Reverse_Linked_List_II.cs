using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Leetcode_92_Reverse_Linked_List_II
    {   
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {

            if (head is null || head.next is null) return head;

            ListNode dummy = new ListNode { next = head };
            ListNode curr = dummy;

            for (int cnt = 0; cnt < left - 1; cnt++) { curr = curr.next; }
 
            var nxt = curr.next;

            // insert head
            for (int cnt = 0; cnt < right - left; cnt++)
            {
                var temp = curr.next;
                curr.next = nxt.next;
                nxt.next = nxt.next.next;
                curr.next.next = temp;
            }

            return dummy.next;
        }
    }
}
