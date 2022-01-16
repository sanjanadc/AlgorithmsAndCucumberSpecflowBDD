using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays
{
    internal class DuplicateZero
    {
        public static void DuplicateZeros(int[] arr)
        {

            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    int loc = i;
                    for (int j = 0; j < loc; j++)
                    {
                        result[j] = arr[j];
                        result[loc] = 0;
                    }
                    for (int j = loc + 1; j < arr.Length; j++)
                    {
                        result[j] = arr[j - 1];
                    }
                }


            }
        }

            static void Main(string[] args)
            {
                int[] nums = { 9, 0, 1 };

            DuplicateZeros(nums);
            }
        }
    }


