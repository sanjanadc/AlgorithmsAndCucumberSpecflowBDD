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
            for (int index = 0; index < arr.Length; index++)
            {
                if (arr[index] == 0)
                {
                    int len = arr.Length - 1;
                    while (len > index)
                    {
                        arr[len] = arr[len - 1];
                        len--;
                    }
                    index++;
                }
            }
        }

            static void Main(string[] args)
            {
                int[] nums = { 1, 0, 2, 3, 0, 4, 5, 0 };

            DuplicateZeros(nums);
            }
        }
    }


