using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class CoinChange
    {
        public int CoinChange_1(int[] coins, int amount)
        {
            if (amount < 0 || coins.Length == 0 || coins == null)
            {
                return 0;
            }
            int[] dp = new int[amount + 1];
            Array.Fill(dp, amount + 1);
            dp[0] = 0;

            for (int i = 1; i <= amount; i++)
            {
                foreach (int coin in coins)
                {
                    if (i - coin >= 0)
                    {
                        dp[i] = Math.Min(dp[i], 1 + dp[i - coin]);
                    }
                }
            }

            return dp[amount] != amount + 1 ? dp[amount] : -1;
        }

    }
}
