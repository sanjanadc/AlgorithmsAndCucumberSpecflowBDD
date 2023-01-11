using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class _132pattern
    {
        public static bool Find132pattern(int[] nums)
        {

            if (nums == null || nums.Length < 3)
                return false;

            Stack<int> stack = new Stack<int>();
            int maxS2 = Int32.MinValue;
            for (int j = nums.Length - 1; j >= 0; j--)
            {
                if (nums[j] < maxS2)
                    return true;

                while (stack.Count > 0 && stack.Peek() < nums[j])
                {
                    maxS2 = Math.Max(maxS2, stack.Pop());
                }

                stack.Push(nums[j]);
            }

            return false;
        }

        //public static void Main()
        //{
        //    int[] nums = { 3, 1, 4, 2 };
        //    Find132pattern(nums);

        //}
    }
}
