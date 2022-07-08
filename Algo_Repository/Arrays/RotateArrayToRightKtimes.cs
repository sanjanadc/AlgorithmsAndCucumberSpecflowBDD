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
            int[] output = new int[nums.Length];
            int length = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                output[(i + k) % length] = nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = output[i];
            }
        }                                                                                                                                                                                                                     
        //public static void Main()
        //{
        //    int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
        //    int k = 3;
        //    Rotate(nums, k);
        //}
    }

}
