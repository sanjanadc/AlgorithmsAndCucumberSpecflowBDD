using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class MergeSortedArray
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            int p1 = m - 1;
            int p2 = n - 1;
           int[] nums3 = new int[m+n];

            for (int p = m + n - 1; p >= 0; p--)
            {
                if (p2 < 0)
                {
                    break;
                }

                if (p1 >= 0 && nums1[p1] > nums2[p2])
                {
                    nums3[p] = nums1[p1--];
                }
                else
                {
                    nums3[p] = nums2[p2--];
                }
            }
        }

        //public static void Main(String[] args)
        //{
        //    int[] a = { 1, 3, 5, 7 };
        //    int[] b = { 2, 4, 6, 8 };
        //    int size = a.Length;
        //    int size1 = b.Length;

        //    // Function call
        //    Merge(a, size,b,size1);
        //}
    }
}
