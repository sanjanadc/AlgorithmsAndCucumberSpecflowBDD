using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class _2399
    {
        public static IList<IList<int>> MinimumAbsDifference(int[] arr)
        {

            List<IList<int>> list = new List<IList<int>>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i]) - Math.Abs(arr[j]) == 1)
                        list.Add(new[] { i + 1, j + 1 });
                }
            }

            return list;
        }

        //public static void Main()
        //{
        //    //int[] num = { 4, 2, 1, 3};
        //    //MinimumAbsDifference(num);
        //    string[,] fruitArray = new string[2, 2] 
        //    {
        //    {"apple" , "mango"} ,   /*  values for row indexed by 0 */
        //    {"orange", "banana"}   /*  values for row indexed by 1 */
        //     };
        //    /* output for the elements present in array*/
        //    for (int i = 0; i<2; i++) {
        //        for (int j = 0; j <2; j++) {
        //            Console.WriteLine("fruitArray[{0},{1}] = {2}", i, j, fruitArray[i, j]);
        //        }
        //    }
        //}
    }
}
