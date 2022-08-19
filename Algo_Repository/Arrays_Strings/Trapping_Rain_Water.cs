using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class Trapping_Rain_Water
    {
        public static int Trap(int[] height)
        {
            if (height == null || height.Length == 0)
                return 0;

            int i = 0;
            int j = height.Length - 1;
            int res = 0;
            int leftHighest = 0;
            int rightHighest = 0;
            while (i <= j)
            {
                if (height[i] < height[j])
                {
                    if (height[i] < leftHighest)
                        res = res + leftHighest - height[i];
                    else
                        leftHighest = height[i];
                    i++;
                }
                else
                {
                    if (height[j] < rightHighest)
                        res = res + rightHighest - height[j];
                    else
                        rightHighest = height[j];
                    j--;
                }
            }
            return res;
        }

        //public static void Main()
        //{
        //    int[] n = { 4, 2, 0, 3, 2, 5 };

        //    Console.WriteLine(Trap(n));

        //}
    }
}
