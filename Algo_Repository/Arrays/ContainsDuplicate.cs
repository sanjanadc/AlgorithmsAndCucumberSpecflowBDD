using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays
{
    internal static class ContainsDuplicate
    {
        
            public  static bool ContainsDupli(int[] nums)
            {
                Dictionary<int, int> map = new Dictionary<int, int>();
                for (int x = 0; x < nums.Length; x++)
                {
                    if (map.ContainsKey(nums[x]))
                        return true;
                    map[nums[x]] = x;
                }
                return false;
            }

        //static void main(string[] args)
        //{
        //    int[] array = { 1, 2, 3 ,1};
            
        //    ContainsDupli(array);

        //}
    }
}
