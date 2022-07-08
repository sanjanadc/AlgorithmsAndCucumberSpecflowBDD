using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays
{
    internal class TwoSum
    {

        public static int[] TwoSums(int[] array, int target)
        {
            Dictionary<int, int> pair = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                int complement = target - array[i];

                if (pair.ContainsKey(complement))
                {
                    return new int[] { pair[complement], i };
                }
                pair[array[i]] = i;
            }
            return null;
        }


        //static void Main(string[] args)
        //{
        //    int[] array = { 2, 7, 11, 15 };
        //    int target = 9;
        //    int[] ans = TwoSums(array, target);
            
        //}
    }
}
//time n space complexity O(n)