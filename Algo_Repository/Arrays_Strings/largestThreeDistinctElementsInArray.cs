using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class largestThreeDistinctElementsInArray
    {
        public static int[] dictinct(int[] arr)
        {
            int i, first, second, third;
            if(arr.Length <3)
                return null;

            first = second = third = 0;
            for(i=0;i<arr.Length;i++)
            {
                if(arr[i]>first)
                {
                    third = second;
                    second= first;
                    first = arr[i];
                }
                else if(arr[i]>second && arr[i]!=first)
                {
                    third = second;
                    second= arr[i];
                }
                else if(arr[i]>third && arr[i]!=second)
                {
                    third=arr[i];
                }
            }
            return new int[] { first, second, third };
        }

        //public static void Main()
        //{
        //    int[] arr = { 10, 4, 3, 50, 23, 90 };
        //    largest_three_distinct_elements_in_array.dictinct(arr);


        //}
    }

   
}
