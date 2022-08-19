using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.LinkedLists
{
    internal class IntersectionofTwoLinked_Lists
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {

            ListNode pA = headA;
            ListNode pB = headB;
            while (pA != pB)
            {
                pA = pA == null ? headB : pA.next;
                pB = pB == null ? headA : pB.next;
            }
            return pA;



        }

    }
}
