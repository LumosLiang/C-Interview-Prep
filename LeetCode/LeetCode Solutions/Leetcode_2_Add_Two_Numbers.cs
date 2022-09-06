using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode_Solutions
{
    public class Leetcode_2_Add_Two_Numbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(0);
            ListNode curr = dummy;
            int carry = 0;

            while (l1 != null || l2 != null || carry != 0)
            {
                if (l1 != null)
                {
                    carry += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    carry += l2.val;
                    l2 = l2.next;
                }

                curr.next = new ListNode(carry % 10);
                curr = curr.next;
                carry /= 10;
            }
            return dummy.next;
            
        }
    }

    //public class ListNode
    //{
    //    public ListNode _nextnode;
    //    public int _val;

    //    public ListNode(int val, ListNode nextNode = null)
    //    {
    //        _nextnode = nextNode;
    //        _val = val;
    //    }

    //}
}
