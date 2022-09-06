using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class PrefixString
    {
        public static int IsPrefixOfWord(string sentence, string searchWord)
        {
            if(sentence == null)
                return -1;

            string[] s = sentence.Split(' ');
            for (int i = 0; i < s.Length; i++) 
            {
                if (s[i].StartsWith(searchWord))
                {
                    return i +1;
                }
                    
            }
            return -1;
        }
        //public static void Main()
        //{
        //    string sentence = "hellohello hellohellohello";
        //    string searchWord = "ello";
        //    int i = IsPrefixOfWord(sentence, searchWord);

        //}
    }
}
