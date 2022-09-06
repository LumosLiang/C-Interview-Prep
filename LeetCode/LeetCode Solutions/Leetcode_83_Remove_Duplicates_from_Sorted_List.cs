using System.Linq;

namespace LeetCode
{
    public class Leetcode_83_Remove_Duplicates_from_Sorted_List
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head is null) return head;

            ListNode curr = head, nxt = head.next;

            while (nxt != null)
            {
                if (curr.val != nxt.val)  
                {
                    curr.next = nxt;
                    curr = curr.next;
                }

                nxt = nxt.next;
            }
            curr.next = nxt;

            return head;
        }
    }
}