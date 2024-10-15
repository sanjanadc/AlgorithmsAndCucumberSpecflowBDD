using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class Find_Minimum_in_Rotated_Sorted_Array_II___with_duplicates
    {
        public static int findMin(int[] nums)
        {
            int low = 0;
            int high = nums.Length - 1;
            while(low<high && nums[low] >= nums[high])
            {
                int m = low + high / 2;
                if (nums[m] > nums[high])
                    low = m + 1;
                else if (nums[m] < nums[low])
                    high= m;
                else
                    low = low + 1;
            }
            return nums[low];
        }


        //public static void Main()
        //{
        //    int[] nums = { 1, 1, 1, 0, 1};
        //    findMin(nums);
        //}

    }
}
