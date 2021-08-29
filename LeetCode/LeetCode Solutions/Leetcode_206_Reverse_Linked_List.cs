namespace LeetCode
{
    public class Leetcode_206_Reverse_Linked_List
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null) return null;
            if (head.next == null) return head;

            ListNode r = ReverseList(head.next);
            head.next.next = head;
            head.next = null;
            return r;
        }
    }
}
