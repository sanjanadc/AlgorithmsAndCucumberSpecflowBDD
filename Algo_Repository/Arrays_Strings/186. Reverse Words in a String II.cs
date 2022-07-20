using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays
{
    internal class _186
    {
        public static void ReverseWords(char[] s)
        {

            if (s == null || s.Length == 0)
                return ;

            reverse(s, 0, s.Length - 1);

            int i = 0, j = 0;
            while (i < s.Length)
            {
                j = i;
                while (j < s.Length && s[j] != ' ')
                    j++;

                reverse(s, i, j - 1);
                i = j + 1;
            }
            
        }
        private static void reverse(char[] s, int i, int j)
        {
            while (i < j)
            {
                char tmp = s[i];
                s[i] = s[j];
                s[j] = tmp;
                i++;
                j--;
            }
        }

        //public static void Main()
        //{
        //    char[] hay = {'f','i',' ','s','e'};

        //    ReverseWords(hay);
        //}
    }
}
