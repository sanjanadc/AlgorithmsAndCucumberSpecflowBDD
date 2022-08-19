using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class Find_First_and_Last_Position_of_Element_in_Sorted_Array
    {
        public static int[] SearchRange(int[] nums, int target)
        {
            return new int[] { FindFirstIndex(nums, target), FindLastIndex(nums, target) };
        }

        private static int FindFirstIndex(int[] nums, int target)
        {
            if (nums.Length == 0) return -1;
            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                var mid = left + (right - left) / 2;
                if (nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid;
            }
            return nums[left] == target ? left : -1;
        }

        private static int FindLastIndex(int[] nums, int target)
        {
            if (nums.Length == 0) return -1;
            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                var mid = left + (right - left + 1) / 2;
                if (nums[mid] > target)
                    right = mid - 1;
                else
                    left = mid;
            }

            return nums[left] == target ? left : -1;
        }

        //public static void Main()
        //{
        //    int[] n = { 5, 7, 7, 8, 8, 10 };
        //    int target = 8;
        //    SearchRange(n, target);
            

        //}
    }
}
