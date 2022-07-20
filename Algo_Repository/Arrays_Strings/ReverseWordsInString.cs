using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays
{
    internal class ReverseWordsInString
    {
        public static string ReverseWords(string str)
        {
            StringBuilder sb = new StringBuilder();
            int wordStart = 0;
            int wordEnd = str.Length - 1;
            int currIndex = str.Length - 1;
            while (currIndex >= 0)
            {
                while (currIndex >= 0 && str[currIndex] == ' ')
                {
                    currIndex--;
                }
                wordEnd = currIndex;
                while (currIndex >= 0 && str[currIndex] != ' ')
                {
                    currIndex--;
                }
                wordStart = currIndex + 1;
                if (wordStart >= 0)
                {
                    sb.Append(str.Substring(wordStart, wordEnd - wordStart + 1));

                }
                sb.Append(" ");
                currIndex--;
            }
            return sb.ToString().Trim();
            


        }


        //public static void Main()
        //{
        //    string hay = "first second";

        //    Console.WriteLine(ReverseWords(hay));
        //}
    }
}
