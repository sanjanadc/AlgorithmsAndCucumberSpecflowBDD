using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class _228SummaryRanges
    {
        public static IList<string> SummaryRanges(int[] nums)
        {

            IList<string> res = new List<string>();

            for (int i = 0; i < nums.Length; i++)
            {
                int start = nums[i];
                while (i + 1 < nums.Length && nums[i + 1] - nums[i] == 1)
                    i++;

                string range = nums[i] == start ? start.ToString() : start + "->" + nums[i];
                res.Add(range);
            }
            return res;
        }

        //public static void Main()
        //{
        //    int[] nums = { 0, 1, 2, 4, 5, 7 };
        //   SummaryRanges(nums);

        //}
    }
}
