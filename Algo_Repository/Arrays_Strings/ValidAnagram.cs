using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class _242_Valid_Anagram
    {
        public static bool Anagram(string a, string b)
        {
            if(a.Length != b.Length)
                return false;
            Dictionary<char,int> map = new Dictionary<char,int>();
            for(int i = 0; i < a.Length; i++)
            {
                if (map.ContainsKey(a[i]))
                    map[a[i]] = map[a[i]] + 1;
                else
                    map.Add(a[i],1);
            }
            for(int i = 0;i < b.Length;i++)
            {
                if(map.ContainsKey(b[i]))
                    map[b[i]] = map[b[i]] - 1;
            }
            var keys = map.Keys;
            foreach (char val in keys)
            {
                if(map[val]!=0)
                    return false;
            }
            return true;
        }
        //public static void Main()
        //{
        //    string a = "sanju";
        //    string b = "sajnu";
        //    Anagram(a, b);

        //}
    }
}
