using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Leetcode_138_Copy_List_with_Random_Pointer

    {
        public NewListNode CopyRandomList(NewListNode head)
        {
            if (head is null) return null;

            Dictionary<NewListNode, NewListNode> hash = new Dictionary<NewListNode, NewListNode>();

            NewListNode curr = head;

            while (curr != null)
            {
                hash[curr] = new NewListNode(curr.val);
                curr = curr.next;
            }

            foreach (var item in hash)
            {
                NewListNode k = item.Key, v = item.Value;
                if (k.next != null) v.next = hash[k.next];
                if (k.random != null) v.random = hash[k.random];
            }

            return hash[head];
        }
    }


    public class NewListNode
    {
        public int val;
        public NewListNode next;
        public NewListNode random;

        public NewListNode(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
}
