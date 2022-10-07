using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class _2341
    {
        public static int[] NumberOfPairs(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (int i in nums)
            {
                if (dic.ContainsKey(i))
                {
                    dic[i] = dic[i] + 1;
                }
                else
                {
                    dic.Add(i, 1);
                }
            }
            int pairCount = 0;
            int leftOver = 0;


            foreach (var kv in dic)
            {
                if (kv.Value % 2 == 0)
                {
                    int total = kv.Value / 2;
                    pairCount = pairCount + total;
                }
                else
                {
                    // Make odd occurences into a pair and then keep track of the non-pairs.
                    if (kv.Value != 1)
                    {
                        pairCount = pairCount + ((kv.Value - 1) / 2);
                    }
                    leftOver++;
                }
            }

            return new int[] { leftOver, pairCount };
        }

        //public static void Main()
        //{
        //    int[] nums = { 1, 3, 2, 1, 3, 2, 2 };

        //    Console.WriteLine(NumberOfPairs(nums));
        //}

    }
}
