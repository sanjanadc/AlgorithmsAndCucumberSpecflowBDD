using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class UnequalTriplets_
    {
        public static int UnequalTriplets(int[] nums)
        {
            Dictionary<int, int> dict = new();
            foreach (var num in nums)
            {
                if (!dict.ContainsKey(num))
                    dict[num] = 0;
                dict[num]++;
            }
            int ans = 0, prev = 0, len = nums.Length;
            foreach (int val in dict.Values)
            {
                len = len- val;
                ans = ans+ prev * val * len;
                prev = prev+ val;

            }
            return ans;
        }

        //public static void Main()
        //{
        //    int[] nums = { 4, 4, 2, 4, 3 };
        //    UnequalTriplets(nums);

        //}
    }
}
