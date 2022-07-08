using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays
{
    internal class ValidPalindrome
    {
        public static bool ValidPalindrome_string(string s)
        {
            int start = 0;
            int end = s.Length - 1;

            while (start < end)
            {
                if (!Char.IsLetterOrDigit(s[start]))
                {
                    start++; 
                    continue;
                }

                if (!Char.IsLetterOrDigit(s[end]))
                {
                    end--;
                    continue;
                }

                if (Char.ToLower(s[start]) != Char.ToLower(s[end]))
                {
                    return false;
                }

                start++;
                end--;
            }

            return true;
        }

        public static void Main()
        {

            string s = "race a car";
            ValidPalindrome_string(s);

        }
    }
}
