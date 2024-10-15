using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class TwoSumII_InputArrayIsSorted
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            int i = 0, j = numbers.Length - 1;
            while (i < j)
            {
                int sum = numbers[i] + numbers[j];
                if (sum < target)
                {
                    i++;
                }
                else if (sum > target)
                {
                    j--;
                }
                else
                {
                    return new int[] { i + 1, j + 1 };
                }
            }

            return null;
        }

        //public static void Main(String[] args)
        //{
        //    int[] str = {2,7,11,15};
        //    int target = 9;
        //    int[]  val = TwoSum(str,target);
        //    Console.Write("{0} ", val);
        //}
    }
}
