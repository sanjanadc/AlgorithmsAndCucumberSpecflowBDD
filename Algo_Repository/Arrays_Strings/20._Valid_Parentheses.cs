using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class _20
    {
        public static bool IsValid(string s)
        {
            Dictionary<char, char> dc = new Dictionary<char, char>();
            dc.Add(')', '(');
            dc.Add(']', '[');
            dc.Add('}', '{');

            int i = 0;
            Stack<char> stack = new Stack<char>();
            while (i < s.Length)
            {
                if (dc.ContainsKey(s[i]))
                {
                    if (stack.Count == 0) return false;
                    if (dc[s[i]] != stack.Pop())
                        return false;
                }
                else
                    stack.Push(s[i]);

                i++;
            }
            if (stack.Count == 0)
                return true;
            else
                return false;
        }
        public static void Main()
        {
            string s = "[[";

            Console.WriteLine(IsValid(s));
        }
    }
}
