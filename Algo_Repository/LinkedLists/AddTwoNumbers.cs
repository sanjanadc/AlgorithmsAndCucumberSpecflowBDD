using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.LinkedLists
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class AddTwoNumbers
    {
        public static  ListNode AddTwoNumbers_1(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(0);
            ListNode curr = dummy;
            int carry = 0;
            while (l1 != null || l2 != null || carry != 0)
            {
                int x = (l1 != null) ? l1.val : 0;
                int y = (l2 != null) ? l2.val : 0;
                int sum = x + y + carry;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;

                if (l1 != null)
                {
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    l2 = l2.next;
                }
            }
            
            return dummy.next;

        }

        public static void Main()
        {
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);
            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            AddTwoNumbers_1(l1, l2);

        }
    }
}
