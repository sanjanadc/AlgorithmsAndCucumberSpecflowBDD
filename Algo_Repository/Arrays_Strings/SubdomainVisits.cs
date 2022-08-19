using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class SubdomainVisits
    {
        public static IList<string> SubdomainVisits_(string[] cpdomains)
        {
            var r = new Dictionary<string, int>();

            foreach (var c in cpdomains)
            {
                var p = c.Split(' ');
                var i = int.Parse(p[0]);
                var s = string.Empty;
                var d = p[1].Split('.');

                for (var j = d.Length - 1; j >= 0; j--)
                {
                    s = d[j] + (s.Length == 0 ? s : ("." + s));
                    if (!r.ContainsKey(s))
                    {
                        r[s] = 0;
                    }

                    r[s] += i;
                }
            }

            return r.Select(e => $"{e.Value} {e.Key}").ToList();
        }

        public static void Main()
        {
            string[] s = { "9001 discuss.leetcode.com" };
            Console.WriteLine(SubdomainVisits_(s));
        }
    }
}
