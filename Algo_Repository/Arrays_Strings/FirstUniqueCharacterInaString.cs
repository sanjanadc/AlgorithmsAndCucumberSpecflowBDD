using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class _387_First_Unique_Character_in_a_String
    {
        public static int FirstUniqChar(string s)
        {
            var dict = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (dict.Keys.Contains(c))
                    dict[c]++;
                else
                    dict.Add(c, 1);
            }

            foreach (var c in s)
            {
                if (dict.Keys.Contains(c) && dict[c] == 1)
                    return s.IndexOf(c);
            }

            return -1;
        }

        //public static void Main()
        //{
        //    string s = "leetcode";
            
        //   Console.WriteLine(FirstUniqChar(s));
        //}

    }
}
