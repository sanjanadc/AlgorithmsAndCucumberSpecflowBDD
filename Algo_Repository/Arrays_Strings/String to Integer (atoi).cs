using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays
{
    internal class String_to_Integer__atoi_
    {
        public static  int stringToInteger_ATOI(string input)
        {
            var sign = 1;
            var result = 0;
            var index = 0;
            var n = input.Length;
            // Discard all spaces from the beginning of the input string.
            while (index < n && input[index] == ' ')
            {
                index++;
            }
            // sign = +1, if it's positive number, otherwise sign = -1.
            if (index < n && input[index] == '+')
            {
                sign = 1;
                index++;
            }
            else if (index < n && input[index] == '-')
            {
                sign = -1;
                index++;
            }
            // Traverse next digits of input and stop if it is not a digit
            while (index < n && char.IsDigit(input[index]))
            {
                var digit = (input[index]) - ('0');
                // Check overflow and underflow conditions.
                if ((result > (int.MaxValue / 10)) || (result == (int.MaxValue / 10) && digit > int.MaxValue % 10))
                {
                    // If integer overflowed return 2^31-1, otherwise if underflowed return -2^31.
                    return sign == 1 ? int.MaxValue : int.MinValue;
                }
                // Append current digit to the result.
                result = 10 * result + digit;
                index++;
            }
            // We have formed a valid number without any overflow/underflow.
            // Return it after multiplying it with its sign.
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
