using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class SingleRowKeyboard
    {

        public static int CalculateTime(string keyboard, string word)
        {
            
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int val = 0;
            foreach (var key in keyboard)
            {
                dic.Add(key, val);
                val++;
            }



            int res = 0, prev = 0;
            foreach (char c in word)
            {
                res = res + Math.Abs(dic[c] - prev);
                prev = dic[c];
            }
            
            return res;


        }

        //public static void Main()
        //{
        //    string word = "cba";
        //    string keyboard = "abcdefghijklmnopqrstuvwxyz";
        //    CalculateTime(keyboard,word);
        //}
    }
}
