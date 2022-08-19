using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class GroupAnagrams
    {
        public static IList<IList<string>> GroupAnagrams_(string[] strs)
        {

            List<IList<string>> res = new List<IList<string>>();
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

            foreach (string str in strs)
            {
                char[] arr = str.ToCharArray();
                Array.Sort(arr);
                string key = new string(arr);

                if (dic.ContainsKey(key))
                    dic[key].Add(str);
                else
                    dic.Add(key, new List<string>() { str });
            }

            foreach (var kv in dic)
            {
                res.Add(kv.Value);
                
            }
         
         
            return res;
        }
        //public static void Main()
        //{
        //    string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

        //    Console.Write(GroupAnagrams_(strs));

            
        //}

    }
}
