using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class _2032_Two_Out_of_Three
    {
        public static IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
        {

            List<int> res = new List<int>();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            helper(nums1, dic);
            helper(nums2, dic);
            helper(nums3, dic);

            foreach (var kv in dic)
            {
                if (kv.Value >= 2)
                    res.Add(kv.Key);
            }

            return res;
        }

        private static void helper(int[] nums, Dictionary<int, int> dic)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (var num in nums)
            {
                if (!set.Contains(num))
                {
                    if (dic.ContainsKey(num))
                        dic[num]++;
                    else
                        dic.Add(num, 1);
                    set.Add(num);
                }
            }
        }

        //public static void Main()
        //{
        //    int[] nums1 = { 1, 1, 3, 2 };
        //    int[] nums2 = { 2, 3 };
        //    int[] nums3 = { 3 };

        //    TwoOutOfThree(nums1, nums2, nums3);
        //}
    }
}
