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
            int sum = 0;
            while (l1 != null || l2 != null || sum != 0)
            {
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                curr.next = new ListNode(sum % 10);
                sum /= 10;
                curr = curr.next;
            }
            return dummy.next;
            
        }


        public ListNode AddTwoNumbersNotInPlace(ListNode l1, ListNode l2)
        {
            return new ListNode(1);
        }

    }
}
