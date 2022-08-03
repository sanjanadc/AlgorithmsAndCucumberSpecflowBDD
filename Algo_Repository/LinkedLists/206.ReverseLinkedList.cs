using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.LinkedLists
{
    internal class _206
    {
        public class Solution
        {
            public ListNode ReverseList(ListNode head)
            {

                ListNode prev = null;
                ListNode cur = head;

                while (cur != null)
                {
                    ListNode temp = cur.next;
                    cur.next = prev;
                    prev = cur;
                    cur = temp;
                }
                return prev;
            }
        }

    }
}
