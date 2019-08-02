using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class _322_coin_change
    {
        public int CoinChange(int[] coins, int amount)
        {
            List<int> List_Num = new List<int>(new int[amount + 1]);

            List_Num[0] = 0;

            for (int i = 1; i <= amount; i++)
            {
                List_Num[i] = int.MaxValue;
                foreach (var coin in coins)
                {
                    if (i - coin >= 0 && List_Num[i - coin] != int.MaxValue)
                    {
                        List_Num[i] = Math.Min(List_Num[i - coin] + 1, List_Num[i]);
                    }
                }

            }
            return List_Num[amount] == int.MaxValue ? -1 : List_Num[amount];

        }
    }
}

