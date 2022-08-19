using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class _202
    {
        public int getNext(int n)
        {
            int totalSum = 0;
            while (n > 0)
            {
                int d = n % 10;
                n = n / 10;
                totalSum += d * d;
            }
            return totalSum;
        }

        public bool IsHappy(int n)
        {
            while (n != 1 && n != 4)
            {
                n = getNext(n);
            }
            return n == 1;
        }

    }
}
