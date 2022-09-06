using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class NumberOfGoodPairs
    {
        public static int NumIdenticalPairs(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i < j)
                    {
                        count++;
                    }
                }

            }
            return count;
        }

        //public static void Main()
        //{
        //    int[] nums = { 1, 2, 3, 1, 1, 3 };
        //    NumIdenticalPairs(nums);
        //}
    }
}
