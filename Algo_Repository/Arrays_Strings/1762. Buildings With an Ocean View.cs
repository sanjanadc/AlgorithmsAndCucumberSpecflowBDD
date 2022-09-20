using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class _1762
    {
        public static int[] FindBuildings(int[] heights)
        {
            List<int> res = new List<int>();
            int n = heights.Length, currMax = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                if (heights[i] > currMax)
                    res.Add(i);

                currMax = Math.Max(currMax, heights[i]);
            }

            res.Reverse();
            return res.ToArray();
        }

        //public static void Main()
        //{
        //    int[] heights = { 4, 2, 3, 1 };
        //    FindBuildings(heights);
        //}
    }
}
