using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.LinkedLists
{
    internal class _141
    {
        public bool HasCycle(ListNode head)
        {

            if (head == null || head.next == null) return false;

            ListNode slow = head;
            ListNode fast = head.next;

            while (fast != null && fast.next != null)
            {
                if (slow == fast) return true;

                slow = slow.next;
                fast = fast.next.next;
            }

            return false;
        }

    }
}
