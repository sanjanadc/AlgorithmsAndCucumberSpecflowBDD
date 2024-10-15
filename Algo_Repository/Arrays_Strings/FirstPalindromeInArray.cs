using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class FirstPalindrome_array
    {
        
            public static string FirstPalindrome(string[] words)
            {
                string str = "";
                bool val;
                foreach (string s in words)
                {
                    int i = 0;
                    int j = s.Length - 1;
                    val = ispalindrome(s, i, j);
                if (val == true)
                    return s;
                }
                return null;
            }

            private static bool ispalindrome(string s, int i, int j)
            {
                
                while (i < j)
                {
                    if (s[i] != s[j])
                    {
                        return false;
                    }
                    i++;
                    j--;

                }

                return true;
            }

        //public static void Main()
        //{
        //    string[] s = { "abc", "car", "ada", "racecar", "cool" };
            
            
        //    Console.WriteLine(FirstPalindrome(s));
        //}
    }

}
