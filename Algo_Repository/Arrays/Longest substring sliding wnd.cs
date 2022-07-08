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
            Dictionary<char, int> map = new Dictionary<char, int>();
            int result = 0;
            int left = 0;
            for (int right = 0; right < s.Length; right++)
            {
                if (map.ContainsKey(s[right]))
                {
                    left = Math.Max(map[s[right]], left);
                }
                result = Math.Max(result, right - left + 1);
                map[s[right]] = right + 1;
            }
            Console.WriteLine("longest substring is " + map.Keys);
            return result;

        }
        //static void Main()
        //{ 
        //    string s = "abcabcbb";
        //    Console.WriteLine("The input string is " + s);
        //    int length = LengthOfLongestSubstring(s);
        //    Console.WriteLine("The length of the longest non-repeating character substring is " + length);
        //}
    }
}
