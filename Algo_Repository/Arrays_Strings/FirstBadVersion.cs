using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class FirstBadVersion
    {
        public class Solution 
        {
            public static int FirstBadVersion(int n)
            {

                int left = 1;
                int right = n;
                while (left < right)
                {
                    int mid = left + (right - left) / 2;
                    if (IsBadVersion(mid))
                    {
                        right = mid;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                return left;
            }
            public static bool IsBadVersion(int n)
            {
                if(n == 4)
                    return true;
                else 
                    return false;
            }

            //public static void Main()
            //{
            //    int n = 5;

            //    Console.WriteLine(FirstBadVersion(n));

            //}
        }
    }
}
