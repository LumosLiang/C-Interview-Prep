namespace LeetCode
{
   
    public class Leetcode_1721_Swapping_Nodes_in_a_Linked_List

    {
        public ListNode SwapNodes(ListNode head, int k)
        {

            int count = 1;
            var fast = head;
            while (count < k)
            {
                fast = fast.next;
                count++;
            }
            var begin = fast;
            var slow = head;
            while (fast.next != null)
            {
                slow = slow.next;
                fast = fast.next;
            }
            var end = slow;

            int tempval = begin.val;
            begin.val = end.val;
            end.val = tempval;

            return head;

        }
    }
}