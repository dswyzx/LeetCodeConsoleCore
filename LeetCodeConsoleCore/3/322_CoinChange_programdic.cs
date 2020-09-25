using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class CoinChange_programdic
    {
        static void Maindic(string[] args)
        {
            int[] coins = new int[] { 83, 186, 408, 419 };
            int ret = CoinChange(coins, 6249);

            Console.WriteLine(ret);
            Console.ReadKey();

        }
        static int CoinChange(int[] coins, int amount)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < amount + 1; i++)
            {
                dic.Add(i, amount + 1);
            }
            dic[0] = 0;
            for (int i = 0; i <= amount; i++)
            {
                for (int j = 0; j < coins.Length; j++)
                {
                    if (coins[j] <= i)
                    {
                        if (dic[i - coins[j]] + 1 < dic[i])
                        {
                            dic[i] = dic[i - coins[j]] + 1;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return (dic[amount] > amount) ? -1 : dic[amount];
        }

    }


}
