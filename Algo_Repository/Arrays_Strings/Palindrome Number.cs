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
            if(x < 0 || x%10 == 0 && x!=0 )
                return false;
            int revert = 0;
            while(x>revert)
            {
                revert = revert * 10 + x % 10;
                x = x % 10;
            }
            return x == revert || x == revert / 10;
        }


        //public static void Main()
        //{
        //    int num = 123216;
        //    Console.WriteLine(IsPalindrome(num));

        //}
    }
}
