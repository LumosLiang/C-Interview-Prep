namespace LeetCode
{
    public class Leetcode_876_Middle_Of_The_Linked_List
    {
        public ListNode MiddleNode(ListNode head)
        {
            var slow = head;
            if (head == null) return slow;
            var fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

            }
            return slow;

        }
    }
}
