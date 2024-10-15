using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class Remove_All_Adjacent_Duplicates_in_string_
    {
        public static string Remove_All_Adjacent_Duplicates_in_string(string s)
        {
            Stack<Char> stack = new Stack<Char>();
            StringBuilder sb = new StringBuilder();
            for(int i = s.Length - 1; i >= 0; i--)
            {
                if(stack.Count == 0 || stack.Peek() != s[i])
                {
                    stack.Push(s[i]);
                }
                else
                {
                    stack.Pop();
                }
            }

            while(stack.Count != 0)
            {
                sb.Append(stack.Pop());
            }

            return sb.ToString();

        }
        //public static void Main()
        //{
        //    string s = "azxxzy";

        //    Remove_All_Adjacent_Duplicates_in_string(s);


        //}
    }
}
