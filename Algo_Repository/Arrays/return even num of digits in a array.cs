using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays
{
     static  class return_even_num_of_digits_in_a_array
    {
        //Given an array nums of integers, return how many of them contain an even number of digits.
        /*Input: nums = [555,901,482,1771]
        Output: 1 
        Explanation: Only 1771 contains an even number of digits. */

         static int FindNumbers_solution1(int[] nums)
        {

            string digit;
            int count =0;
            for(int i =0;i<nums.Length;i++)
            {
                digit = Convert.ToString(nums[i]);
                if(digit.Length % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] arr = { 555, 901, 482, 1771 };
            Console.WriteLine(FindNumbers_solution1(arr));
        }
    }
}
