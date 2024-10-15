using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class _153
    {

        public static int FindMin(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            int left = 0, right = nums.Length - 1;
     if (nums[right] > nums[0])
            {
                return nums[0];
            }

            while (right >= left)
            {
                
                int mid = left + (right - left) / 2;
               if (nums[mid] > nums[mid + 1])
                {
                    return nums[mid + 1];
                }
               if (nums[mid - 1] > nums[mid])
                {
                    return nums[mid];
                }
                if (nums[mid] > nums[0])
                {
                    left = mid + 1;
                }
                else
                {
                  
                    right = mid - 1;
                }
            }
            return int.MaxValue;

        }

        //public static void Main()
        //{
        //    int[] num = { 3, 4, 5, 1, 2 };

        //    Console.WriteLine(FindMin(num));

        //}

    }
}
