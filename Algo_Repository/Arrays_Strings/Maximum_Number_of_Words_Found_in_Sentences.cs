using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class Maximum_Number_of_Words_Found_in_Sentences
    {
        public static int MostWordsFound(string[] sentences)
        {
            int max = 0;
            for (int i = 0; i < sentences.Length; i++)
            {
                string[] s = sentences[i].Split(' ');
                max = Math.Max(max, s.Length);
            }

            return max;
        }

        //public static void Main()
        //{
        //    string[] sentences = { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };

        //    int i = MostWordsFound(sentences);
        //}
    }
}
