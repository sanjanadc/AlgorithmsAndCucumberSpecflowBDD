using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays
{
    internal class Remove_Duplicates_from_Sorted_Array
    {
        class Remove_Duplicates_from_Sorted_Array1
        {

            // Function to remove duplicate
            // elements This function returns
            // new size of modified array.
            static int removeDuplicates(int[] arr)
            {
                int n = arr.Length;
                if (n == 0 || n == 1)
                    return n;

                // To store index of next
                // unique element
                int j = 0;

                for (int i = 0; i < n - 1; i++)
                {
                    if (arr[i] != arr[i + 1])
                        arr[j++] = arr[i];
                    
                }

                arr[j++] = arr[n - 1];
                Console.WriteLine(j);
                
                return j;
                 
            }

            //static void Main()
            //{
            //    int[] arr = { 1, 2, 2, 3, };


            //    int val = removeDuplicates(arr);

            //    //Print updated array
            //    for (int i = 0; i < val; i++)
            //        Console.Write(arr[i] + " ");
            //}
        }

    }
}

//Time Complexity : O(n)
//Auxiliary Space : O(1)
