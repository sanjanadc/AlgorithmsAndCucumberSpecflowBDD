using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class _680_ValidPalindromeII
    {
        public bool ValidPalindrome(string s)
        {

            if (s == "")
                return true;

            int i = 0, j = s.Length - 1;

            while (i < j)
            {
                if (s[i] != s[j])
                    return IsPalindrome(s, i + 1, j) || IsPalindrome(s, i, j - 1);

                i++;
                j--;
            }

            return true;
        }

        private bool IsPalindrome(string s, int i, int j)
        {
            while (i < j)
            {
                if (s[i] != s[j])
                    return false;

                i++;
                j--;
            }

            return true;
        }

    }
}
