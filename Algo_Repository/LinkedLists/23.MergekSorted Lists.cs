using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.LinkedLists
{
    internal class _23
    {
        public static ListNode MergeKLists(ListNode[] lists)
        {

            int size = lists.Length;
            int interval = 1;
            while (interval < size)
            {
                for (int i = 0; i < size - interval; i = i+ 2 * interval)
                {
                    lists[i] = merge(lists[i], lists[i + interval]);
                }
                interval = interval* 2;
            }
            return size > 0 ? lists[0] : null;
        }

        private static ListNode merge(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(0);
            ListNode curr = dummy;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    curr.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    curr.next = l2;
                    l2 = l2.next;
                }
                curr = curr.next;
            }
            if (l1 != null)
            {
                curr.next = l1;
            }
            else
            {
                curr.next = l2;
            }

            return dummy.next;
        }

        //public static void Main()
        //{

        //    // Number of linked lists
        //    int k = 3;

        //    // an array of pointers storing the
        //    // head nodes of the linked lists
        //    ListNode[] arr = new ListNode[k];

        //    arr[0] = new ListNode(1);
        //    arr[0].next = new ListNode(2);
        //    arr[0].next.next = new ListNode(3);
        //    arr[0].next.next.next = new ListNode(4);

        //    arr[1] = new ListNode(5);
        //    arr[1].next = new ListNode(6);
        //    arr[1].next.next = new ListNode(7);
        //    arr[1].next.next.next = new ListNode(8);

        //    arr[2] = new ListNode(9);
        //    arr[2].next = new ListNode(10);
        //    arr[2].next.next = new ListNode(11);
        //    arr[2].next.next.next = new ListNode(12);

        //    // Merge all lists
        //    ListNode head = MergeKLists(arr);
        //    Console.WriteLine(head);
       // }

    }
}
