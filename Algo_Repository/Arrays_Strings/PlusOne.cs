using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class PlusOne_1
    {
        public static int[] PlusOne(int[] digits)
        {
            int n = digits.Length;

            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            int[] new_arr = new int[n + 1];
            new_arr[0] = 1;
            return new_arr;
        }

        //public static void Main()
        //{
        //    int[] nums = { 9, 9, 9 };
        //    PlusOne(nums);
        //}
    }
}
