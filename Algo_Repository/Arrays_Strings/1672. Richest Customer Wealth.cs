using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class _1672
    {

        public static int MaximumWealth(int[][] accounts)
        {

            if (accounts == null || accounts.Length == 0)
                return 0;

            int max = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    sum += accounts[i][j];
                }
                max = Math.Max(max, sum);
            }

            return max;

        }

        //public static void Main()
        //{
        //    int[][] jagged_arr = {
        //    new int[ ] {1,5},
        //    new int[ ] {7,2},
        //    };
        //    MaximumWealth(jagged_arr);
        //}
    }
}
