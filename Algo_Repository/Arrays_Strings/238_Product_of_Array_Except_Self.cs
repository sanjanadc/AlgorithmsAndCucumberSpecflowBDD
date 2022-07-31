using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class _238_Product_of_Array_Except_Self
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int length = nums.Length;
            int[] answer = new int[length];

            answer[0] = 1;
            for (int i = 1; i < length; i++)
            {
                answer[i] = nums[i - 1] * answer[i - 1];
            }
            int R = 1;
            for (int i = length - 1; i >= 0; i--)
            {
                answer[i] = answer[i] * R;
                R *= nums[i];
            }

            return answer;

        }

        //public static void Main()
        //{
        //int[] num = {1,2,3,4};
        //int[] nums = ProductExceptSelf(num);
        //   foreach(int i in nums)
        //      Console.WriteLine(i);
        //}
    }
}
