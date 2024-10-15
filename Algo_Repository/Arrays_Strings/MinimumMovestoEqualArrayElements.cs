using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class Minimum_Moves_to_Equal_Array_Elements
    {
        public static int MinMoves(int[] nums)
        {

            Array.Sort(nums);

            int count = 0;

            for (int i = nums.Length-1; i > 0; i--)
            {
                count = count + nums[i] - nums[0];
            }

            return count;
        }

        //public static void Main()
        //{
        //    int[] nums = { 1, 1, 1, 0, 1 };
        //    MinMoves(nums);
        //}
    }
}
