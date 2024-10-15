using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class _205
    {
        public static bool IsIsomorphic(string s, string t)
        {

            Dictionary<char, char> dict = new Dictionary<char, char>();

            if (s.Length != t.Length)
                return false;

            for (int i = 0; i < s.Length; i++)
            {
                // characters of string s are keys 
                if (dict.ContainsKey(s[i]))
                {
                    if (dict[s[i]] != t[i])
                        return false;
                }
                // if value was mapped to some other key previously 
                else if (dict.ContainsValue(t[i]))
                {
                    return false;
                }
                else
                {
                    dict.Add(s[i], t[i]);
                }
            }

            return true;
        }

        //public static void Main()
        //{
        //    string s = "egg";
        //    string t = "adf";
        //    IsIsomorphic(s,t);

        //}
    }
}
