using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class HowManyNumbersAreSmallerThantheCurrentNumber
    {
        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {

            int count = 0;
            int[] arr = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                        count++;
                }
                arr[i] = count;
                count = 0;
            }
            return arr;
        }

       

    }
}
