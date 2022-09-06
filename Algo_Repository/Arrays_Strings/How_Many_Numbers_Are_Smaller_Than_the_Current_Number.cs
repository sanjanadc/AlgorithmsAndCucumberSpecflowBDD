using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class How_Many_Numbers_Are_Smaller_Than_the_Current_Number
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

        public static void Main()
        {
            int[] nums = { 8, 1, 2, 2, 3 };
            SmallerNumbersThanCurrent(nums);
        }

    }
}
