namespace LeetCode
{
    public class Leetcode_206_Reverse_Linked_List
    {
        // recursive
        public ListNode ReverseList(ListNode head)
        {
            if (head == null) return null;
            if (head.next == null) return head;

            ListNode r = ReverseList(head.next);
            head.next.next = head;
            head.next = null;
            return r;
        }

        // iterative
        public ListNode ReverseList2(ListNode head)
        {
            ListNode pre = null, nxt = null, curr = head;

            while (curr != null)
            {
                nxt = curr.next;
                curr.next = pre;
                pre = curr;
                curr = nxt;
            }
            return head;
        }
    }
}
