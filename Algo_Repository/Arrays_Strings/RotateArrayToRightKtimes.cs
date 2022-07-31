using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays
{
    internal class RotateArrayToRightKtimes
    {
        public static void Rotate(int[] nums, int k)
        {
            k =k % nums.Length;
            reverse(nums, 0, nums.Length - 1);
            reverse(nums, 0, k - 1);
            reverse(nums, k, nums.Length - 1);
        }   
        static void reverse(int[] nums, int start, int end)
        {
                while (start < end)
                {
                    int temp = nums[start];
                    nums[start] = nums[end];
                    nums[end] = temp;
                    start++;
                    end--;
                }
            
        }
        //public static void Main()
        //{
        //    int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
        //    int k = 8;
        //    Rotate(nums, k);
        //}
    }

}
