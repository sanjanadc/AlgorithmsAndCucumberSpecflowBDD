using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class PartitionEqualSubsetSum
    {
        public static int test_1( int[] nums)
        {
            int lsum = 0;
            int sum = nums.Sum();
         
            
            for(int i =0;i<nums.Length;i++)
            {
                if(lsum == sum-lsum)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.WriteLine("first arry" + nums[j]);
                    }

                    for(int k = i;k<nums.Length;k++)
                    {
                        Console.WriteLine("second" + nums[k]);
                    }
                }
                else 
                {
                    lsum = lsum+nums[i];
                }

            }

            return lsum != sum - lsum ? -1 : 0;
        }

        //public static void Main()
        //{
        //    int[] nums = {2,2,1,1};

        //    test_1(nums);

        //}
    }
}
