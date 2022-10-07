using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class _1460
    {
        public static bool CanBeEqual(int[] target, int[] arr)
        {

            Array.Sort(target);
            Array.Sort(arr);

            if (target.Length != arr.Length)
                return false;

            int j = 0;
            for (int i = 0; i < target.Length; i++)
            {
                
                    if (target[i] != arr[j])
                        return false;
                j++; 
            }
            return true;
        }

        //public static void Main()
        //{
        //    int[] target = { 1, 2, 3, 4 };
        //    int[] arr = { 2, 4, 1, 3 };
        //    CanBeEqual(target, arr);
        //}
    }
}
