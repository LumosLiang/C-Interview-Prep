using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode_Solutions
{
    class Leetcode_25_Reverse_Nodes_in_k_Group
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {

            if (head is null || head.next is null) return head;

            ListNode dummy = new ListNode() { next = head };
            var curr = dummy;

            int length = 0;
            while (curr != null)
            {
                curr = curr.next;
                length++;
            }
            length--;

            curr = dummy;

            for (int i = 0; i < length / k; i++)
            {
                var nxt = curr.next;
                for (int j = 0; j < k - 1; j++)
                {
                    var temp = curr.next;
                    curr.next = nxt.next;
                    nxt.next = nxt.next.next;
                    curr.next.next = temp;

                }
                curr = nxt;
            }
            return dummy.next;
        }

    }
}
