using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class _3Sum
    {
        public static IList<IList<int>> Threesum(int[] nums)
        {
            List<IList<int>> res = new List<IList<int>>();
            if(nums == null || nums.Length < 3)
                return res;
            Array.Sort(nums);
            for(int i =0;i<nums.Length-2;i++)
            {
                if (nums[i] > 0 || (i > 0 && nums[i] == nums[i - 1]))
                    continue;
                int left = 0;
                int right=nums.Length-1;
                if(nums[i] +nums[right]+nums[left] == 0)
                {
                    res.Add(new List<int>() { nums[i],nums[left],nums[right] });
                    left++;
                    right--;
                }
                else if(nums[i] + nums[right] + nums[left] > 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
            return res;
        }

        //public static void Main()
        //{
        //    int[] n = { -1, 0, 1, 2, -1, -4 };
        //    int[] res = { };
        //    IList<IList<int>> map = Threesum(n);
          

        //}
    }
}
