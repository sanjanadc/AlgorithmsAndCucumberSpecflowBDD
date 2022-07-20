using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays
{
    internal class RemoveElement
    {
        public int RemoveElementFromArray(int[] nums, int val)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[counter++] = nums[i];
                }
            }
            return counter;
        } 
    }
}
//time complexity is o(k)
//space complexity is o(1)