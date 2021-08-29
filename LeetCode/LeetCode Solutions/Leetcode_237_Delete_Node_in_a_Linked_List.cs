namespace LeetCode
{
    public class Leetcode_237_Delete_Node_in_a_Linked_List

    {
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}