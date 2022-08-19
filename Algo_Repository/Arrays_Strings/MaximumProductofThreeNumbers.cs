using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class MaximumProductofThreeNumbers
    {
        public int MaximumProduct(int[] nums)
        {
            int n = nums.Length;
            if (n < 3)
            {
                return -1;
            }

            // Sort the array in ascending order
            Array.Sort(nums);

            // Return the maximum of product of last three
            // elements and product of first two elements
            // and last element

            return Math.Max(nums[0] * nums[1] * nums[n - 1],
                    nums[n - 1] * nums[n - 2] * nums[n - 3]);
        }

    }
}
