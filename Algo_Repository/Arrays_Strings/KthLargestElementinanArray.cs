using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class KthLargestElementinanArray
    {
        public int FindKthLargest(int[] nums, int k)
        {
            var queue = new PriorityQueue<int, int>();

            foreach (var num in nums)
            {
                queue.Enqueue(num, num);
                if (queue.Count <= k) continue;
                queue.Dequeue();
            }

            return queue.Peek();
        }

    }
}
