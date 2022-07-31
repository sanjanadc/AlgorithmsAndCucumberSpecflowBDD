using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class _724_Find_Pivot_Index
    {
        public static int PivotIndex(int[] nums)
        {

            if (nums == null || nums.Length == 0)
                return -1;

            int sum = nums.Sum();

            int leftsum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (leftsum == sum - leftsum - nums[i])
                    return i;
                else
                    leftsum = leftsum + nums[i];
            }

            return -1;
        }
       
        //public static void Main()
        //{
        //    int[] nums = {1,7,3,6,5,6};

        //    Console.WriteLine(PivotIndex(nums));

        //}
    }
}
