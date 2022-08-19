using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class _409
    {
        public static int LongestPalindrome(string s)
        {

            int result = 0;
            int[] char_count = new int[128];
            foreach (char c in s)
            {
                char_count[c]++;
            }
            foreach (int c in char_count)
            {
                result = result + c / 2 * 2;
                if ((result % 2 == 0) && (c % 2 == 1))
                {
                    result = result + 1;
                }
            }
            return result;
        }

        //public static void Main()
        //{
        //    string s = "abccccdd";
        //    LongestPalindrome(s);
        //}
    }
}
