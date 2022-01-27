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
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    int len = arr.Length - 1;
                    while (len > i)
                    {
                        arr[len] = arr[len - 1];
                        len--;
                    }
                    i++;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 0, 2, 3, 0 };

            DuplicateZeros(nums);
        }
    }
    }


