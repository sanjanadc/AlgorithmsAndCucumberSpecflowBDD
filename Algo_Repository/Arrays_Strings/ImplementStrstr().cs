using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays
{
    internal class ImplementStrstr__
    {
        public static int StrStr(string haystack, string needle)
        {
            if (needle == "")
                return 0;

            for (int i = 0; i < haystack.Length - (needle.Length - 1); i++)
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                        break;
                    if (j + 1 == needle.Length)
                        return i;
                    
                }
            }
            return -1;
            
        }

        //public static void Main()
        //{
        //    string hay = "hello";
        //    string needle = "ll";
        //    Console.WriteLine(StrStr(hay, needle));
        //}
    }
    
}
//O(nm) runtime, O(1) space – Brute force:
//n = length of haystack and m = length of needle, then the runtime 
//complexity is O(nm).