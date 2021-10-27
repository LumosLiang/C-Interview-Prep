namespace LeetCode
{
    public class Leetcode_203_Remove_Linked_List_Elements
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode pre = new ListNode(0, head);
            var curr = pre;

            while (curr.next != null)
            {
                if (curr.next.val == val)
                {
                    curr.next = curr.next.next;
                }
                else
                {
                    curr = curr.next;
                }
            }
            return pre.next;
        }
    }
}
