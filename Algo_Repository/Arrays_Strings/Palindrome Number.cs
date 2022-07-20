using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays
{
    internal class Palindrome_Number
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            int div = 1,l=0,r=0;
            while (x / div >= 10)
            {
                div *= 10;
            }
            while (x != 0)
            {
                 l = x / div;
                 r = x % 10;
                if (l != r) return false;
                x = (x % div) / 10;
                div /= 100;
            }
            return true;
            
        }


        //public static void Main()
        //{
        //    int num = 121;
        //    Console.WriteLine(IsPalindrome(num));

        //}
    }
}
