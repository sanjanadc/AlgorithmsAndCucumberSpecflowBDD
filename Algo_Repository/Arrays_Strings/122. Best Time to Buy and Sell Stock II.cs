using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class del
    {
        public static int BestTimetoBuyandSellStockII(int[] prices)
        {
            int maxprofit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                    maxprofit += prices[i] - prices[i - 1];
            }
            return maxprofit;
        }

        //public static void Main()
        //{
        //    int[] s = { 7, 1, 5, 3, 6, 4 };
        //    BestTimetoBuyandSellStockII(s);




        //}
    }

    

}
