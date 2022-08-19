using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class Unique_Email_Addresses
    {
		public static int NumUniqueEmails(string[] emails)
		{
			var set = new HashSet<string>();
			foreach (var email in emails)
			{
				var str = email.Split("@");
				var sb = new StringBuilder();
				foreach (var chr in str[0])
				{
					if (chr == '.')
						continue;
					else if (chr == '+')
						break;
					else
						sb.Append(chr);
				}

				set.Add(sb.ToString() + "@" + str[1]);
			}

			return set.Count;

		}


   //     public static void Main()
   //     {
   //         string[] s = { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" };

			//Console.WriteLine(NumUniqueEmails(s));
   //     }
    }
}
