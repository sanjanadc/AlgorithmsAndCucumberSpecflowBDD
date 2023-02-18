using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class Interleaving_String
    {
		public static bool IsInterleave(string s1, string s2, string s3)
		{

			int n = s1.Length;
			int m = s2.Length;
			int l = s3.Length;

			if (l == 0)
			{
				return true;
			}

			if (n + m != l)
			{
				return false;
			}

			HashSet<(int, int)> state = new HashSet<(int, int)>();
			if (n > 0 && s1[0] == s3[0])
			{
				state.Add((1, 0));
			}
			if (m > 0 && s2[0] == s3[0])
			{
				state.Add((0, 1));
			}

			while (state.Count > 0)
			{
				var newState = new HashSet<(int, int)>();

				foreach (var (first, second) in state)
				{
					if (first + second == l)
					{
						return true;
					}

					if (first < n && s1[first] == s3[first + second])
					{
						newState.Add((first + 1, second));
					}
					if (second < m && s2[second] == s3[first + second])
					{
						newState.Add((first, second + 1));
					}
				}

				state = newState;
			}

			return false;


		}

        //public static void Main()
        //{
        //    string s1 = "aabcc";
        //    string s2 = "dbbca";
        //    string s3 = "aadbbcbcac";

        //    IsInterleave(s1, s2, s3);


        //}
    }
}
