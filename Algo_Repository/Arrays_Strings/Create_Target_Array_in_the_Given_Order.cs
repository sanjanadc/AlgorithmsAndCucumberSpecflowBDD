using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class Create_Target_Array_in_the_Given_Order
    {
        public static int[] CreateTargetArray(int[] nums, int[] index)
        {

            List <int> list= new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                list.Insert(index[i], nums[i]);

            }
            return list.ToArray();
        }

        //public static void Main()
        //{
        //    int[] nums = { 0, 1, 2, 3, 4 };
        //    int[] index = { 0, 1, 2, 2, 1 };
        //    CreateTargetArray(nums, index);
        //}
    }
}
