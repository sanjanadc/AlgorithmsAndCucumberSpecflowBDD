using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class permutations
    {
        public static int CountKDifference(int[] nums, int k)
        {
            Dictionary<int, int> preSum = new Dictionary<int, int>();
            preSum.Add(0, 1);
            int count = 0, sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (preSum.ContainsKey(sum - k))
                    count += preSum[sum - k];

                if (preSum.ContainsKey(sum))
                    preSum[sum]++;
                else
                    preSum.Add(sum, 1);
            }

            return count;
        }


        //public static void Main()
        //{
        //    int[] nums = { 1, 1, 1 };

        //    permutations.CountKDifference(nums,2);

        //}
    }
}
