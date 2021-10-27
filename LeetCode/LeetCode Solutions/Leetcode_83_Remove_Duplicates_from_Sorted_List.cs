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
                if (curr.val == nxt.val)
                {
                    nxt = nxt.next;
                }
                else
                {
                    curr.next = nxt;
                    curr = nxt;
                    nxt = curr.next;
                }
                
            }
            curr.next = nxt;

            return head;
        }
    }
}