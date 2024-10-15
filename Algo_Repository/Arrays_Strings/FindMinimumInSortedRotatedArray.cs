using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class Find_Minimum_in_Sorted_Rotated_Array
    {
        public static int findMin(int[] A)
        {
            int L = 0, R = A.Length - 1;
            while (L < R && A[L] >= A[R])
            {
                int M = (L + R) / 2;
                if (A[M] > A[R])
                {
                    L = M + 1;
                }
                else
                {
                    R = M;
                }
            }
            return A[L];
        }

        //public static void Main()
        //{
        //    int[] nums = { 3,4,5,1,2 };
        //    findMin(nums);
        //}


    }
}
