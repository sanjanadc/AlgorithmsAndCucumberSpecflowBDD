using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays
{
    internal class String_to_Integer__atoi_
    {
        public static  int stringToInteger_ATOI(string s)
        {
            int result = 0;
            int sign = 1;
            int CurrIndex = 0;
            int size = s.Length;

            //1- if exist exclude leading white spaces
            while (CurrIndex < size && s[CurrIndex] == ' ')
                CurrIndex++;

            // 2- now index is pointing to non space charachter
            //      if next char is - or + then set the sign var
            if (CurrIndex < size)
            {
                if (s[CurrIndex] == '-')
                {
                    sign = -1;
                    CurrIndex++;
                }
                else if (s[CurrIndex] == '+')
                {
                    sign = 1;
                    CurrIndex++;
                }
            }

            while (CurrIndex < size && Char.IsDigit(s[CurrIndex]))
            {
                if (!(s[CurrIndex] - '0' >= 0 && s[CurrIndex] - '0' <= 9))
                    return -1;
                //else just keep updating the result
                result = result * 10 + s[CurrIndex] - '0';
                CurrIndex++;
            }

                return sign * result;
        }

        // Driver code
        //public static void Main(String[] args)
        //{
        //    string str = " -123";
        //    int val = stringToInteger_ATOI(str);
        //    Console.Write("{0} ", val);
        //}
    }
}
