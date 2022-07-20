using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays
{
    internal class LC_557_Reverse_words_in_a_string
    {
            public static string ReverseWords(string s)
            {

                // if(s == null || s.Length == 0)// sanity check when string is empty/null
                //    return s;
                int i = 0, j = 0;//lets take two pointers
                char[] str = s.ToCharArray();
                while (j <= str.Length)//start while loop to reverse each word
                {
                    //when we encounter space we call reverse method
                    if (j == str.Length || str[j] == ' ')
                    {
                        reverse(str, i, j - 1);//j-1 will be end of word

                        i = j + 1;
                    }
                    j++;
                }

                return new String(str);
            }

            public static void reverse(char[] str, int left, int right)
            {
                left = 0;
                right = str.Length - 1;
                for (; left < right; left++, right--)
                {
                    char temp = str[left];
                    str[left] = str[right];
                    str[right] = temp;
                }
            }

            //public static void Main()
            //{
            //    string hay = "hello hi";

            //    Console.WriteLine(ReverseWords(hay));
            //}
        

     
    }
}
