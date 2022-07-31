using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository
{
    public  class Longest_Palindromic_Substring
    {

        int start = 0;
        int length = 0;

        public string LongestPalindrome(string s)
        {

            if (s.Length <= 1)
                return s;
            for (int i = 0; i < s.Length; i++)
            {
                ExpandFromMiddle(s, i, i);
                ExpandFromMiddle(s, i, i + 1);

            }
            return s.Substring(start, length);
        }

        public void ExpandFromMiddle(string s, int i, int j)
        {//racecar
            while (i >= 0 && j < s.Length && s[i] == s[j])
            {
                i--;
                j++;
            }
            if (j - i - 1 > length)
            {
                length = j - i - 1;
                start = i + 1;
            }
        }




        //public static void Main()
        //{
        //    string s = "sdfsas56";
        //    Longest_Palindromic_Substring str = new Longest_Palindromic_Substring();
        //    Console.WriteLine(str.LongestPalindrome(s));
        //}

    }
}

//Time complexity : O(n^2)
//Since expanding a palindrome around its center could take O(n)time, the overall complexity is O(n^2)

//Space complexity : O(1)
