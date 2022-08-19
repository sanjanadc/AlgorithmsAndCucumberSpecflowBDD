using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class IntegerToRoman
    {
        public static string IntToRoman(int num)
        {

            if (num < 1)
                throw new ArgumentException("Invaid Input.");

            string[] roman = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] nums = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            string res = "";
            int i = 0;

            while (num > 0)
            {
                while (num >= nums[i])
                {
                    res = res + roman[i];
                    num = num - nums[i];
                }
                i++;
            }

            return res;

        }

        //public static void Main()
        //{
        //    int num = 10;

        //    Console.Write(IntToRoman(num));


        //}
    }
}
