using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays
{
    static class Squares_of_a_Sorted_Array
    {
        public static int[] SortedSquares(int[] nums)
        {
            int a = 0;
            int b = nums.Length - 1;

            int[] res = new int[b + 1];
            int pos = b;

            while (a <= b)
            {
                if (Math.Abs(nums[a]) > Math.Abs(nums[b]))
                {
                    res[pos--] = nums[a] * nums[a];
                    a++;
                }
                else
                {
                    res[pos--] = nums[b] * nums[b];
                    b--;
                }
   
            }

            return res;
        }
    

        //static void Main(string[] args)
        //{
        //    int[] nums = { 9,2,1 };

        //    SortedSquares(nums);
        //}
    }
}
