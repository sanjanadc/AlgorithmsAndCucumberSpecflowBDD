using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays
{
    internal static class Reverse_Integer
    {
        public static int Reverse(int x)
        {

            int result = 0;
            int prev = 0;
            int cur;
            while (x != 0)
            {
                cur = x % 10;
                x = x / 10;
                result = result * 10 + cur;
                if ((result - cur) / 10 != prev)
                    return 0;
                prev = result;

            }
            return result;
        }

        //public static void Main()
        //{
        //    int x = -123;
        //    Console.WriteLine(Reverse(x));
        //}
    }
}
