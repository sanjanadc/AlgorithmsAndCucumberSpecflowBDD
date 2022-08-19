using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var charAndCount = new int[256];
            foreach (var c in magazine)
            {
                charAndCount[c]++;
            }

            foreach (var c in ransomNote)
            {
                charAndCount[c]--;

                if (charAndCount[c] < 0)
                {
                    return false;
                }
            }

            return true;

        }

    }
}
