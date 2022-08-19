using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {

            if (n == 1)
            {
                return 1;
            }
            int first = 1;
            int second = 2;
            for (int i = 3; i <= n; i++)
            {
                int third = first + second;
                first = second;
                second = third;
            }
            return second;
        }

    }
}
