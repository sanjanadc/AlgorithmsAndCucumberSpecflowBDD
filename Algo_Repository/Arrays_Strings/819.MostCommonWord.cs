using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class _819
    {
        public static string MostCommonWord(string paragraph, string[] banned)
        {
            HashSet<string> set = new HashSet<string>(banned);

        

            foreach (var str in paragraph.Replace("!", " ")
                                         .Replace("?", " ")
                                         .Replace("'", " ")
                                         .Replace(",", " ")
                                         .Replace(";", " ")
                                         .Replace(".", " ")
                                         .ToLower()
                                         .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                         .GroupBy(x => x)
                                         .OrderByDescending(x => x.Count())
                                         .Select(x => x.Key))
                if (!set.Contains(str))
                    return str;

            return string.Empty;
        }

        //public static void Main()
        //{
        //    string s = "Bob hit a ball, the hit BALL flew far after it was hit.";
        //    string[] str = { "hit" };
        //    MostCommonWord(s, str);


        //    }
        }
}
