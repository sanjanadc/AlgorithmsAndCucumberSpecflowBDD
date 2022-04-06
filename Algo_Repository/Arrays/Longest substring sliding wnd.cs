using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays
{
    internal class Longest_substring_sliding_wnd
    {

        public static int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> val = new Dictionary<char, int>();
            int j = 0, max = 0,i=0;
            for (; i < s.Length; i++)
            {
                if(val.ContainsKey(s[i]))
                    j = Math.Max(j, val[s[i]] + 1);

                val[s[i]] = i;
                max = Math.Max(max, i - j + 1);
                
            }
            return max;
        }
        static void Main()
        {
            string s = "abcabcbb";
            Console.WriteLine("The input string is " + s);
            int length = LengthOfLongestSubstring(s);
            Console.WriteLine("The length of the longest non-repeating character substring is " + length);
        }
    }
}
