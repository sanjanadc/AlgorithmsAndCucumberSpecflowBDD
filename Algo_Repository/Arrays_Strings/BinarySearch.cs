using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class BinarySearch
    {
        public static int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                // Prevent (left + right) overflow
                int mid = left + (right - left) / 2;
                if (nums[mid] == target) { return mid; }
                else if (nums[mid] < target) { left = mid + 1; }
                else { right = mid - 1; }

            }
            return -1;
        }


        //public static void Main()
        //{
        //    int[] num = {1,2,3,4,5,6};
        //    int target = 5;
        //    Console.WriteLine(Search(num,target));

        //}
    }

}

