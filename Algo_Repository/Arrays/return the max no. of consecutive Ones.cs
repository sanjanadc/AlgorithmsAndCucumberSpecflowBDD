using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays
{
//Given a binary array nums, return the maximum number of consecutive 1's in the array.
/*Input: nums = [1,1,0,1,1,1]
Output: 3
Explanation: The first two digits or the last three digits are consecutive 1s. 
The maximum number of consecutive 1s is 3.*/
 public static class max_no_Ones
{
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                }
                else
                {
                    max = Math.Max(max, count);
                    count = 0;
                }
            }
            max = Math.Max(max, count);
            return max;
        }

        public  static void Main(string []args)
        {
            int[] nums = { 1, 1, 0, 1, 1, 1 };
            
            Console.WriteLine(FindMaxConsecutiveOnes(nums));
        }


    }
}
