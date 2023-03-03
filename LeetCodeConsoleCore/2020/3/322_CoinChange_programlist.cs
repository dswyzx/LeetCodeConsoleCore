using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class CoinChange_programlist
    {
        static void Mainlist(string[] args)
        {
            int[] coins = new int[] { 83, 186, 408, 419 };
            int ret = CoinChange(coins, 6249);

            //int[] coins = new int[] { 1, int.MaxValue };
            //int ret = CoinChange(coins, 2);

            //int[] coins = new int[] { 1, 5, 2 };
            //int ret = CoinChange(coins, 11);


            Console.WriteLine(ret);
            Console.ReadKey();

        }
        static int CoinChange(int[] coins, int amount)
        {
            List<int> cor = new List<int>(coins);
            cor.Sort();
            coins = cor.ToArray();

            if (amount == 0)
            {
                return 0;
            }
            if (amount < coins[0])
            {
                return -1;
            }
            List<int> lis = new List<int>();
            for (int i = 0; i <= amount; i++)
            {
                lis.Add(int.MaxValue);
            }
            lis[0] = 0;
            for (int i = 0; i < coins.Length; i++)
            {
                if (coins[i] > amount)
                {
                    break;
                }
                lis[coins[i]] = 1;
            }
            for (int i = coins[0]; i <= amount; i++)
            {
                int max = int.MaxValue;
                for (int j = 0; j < coins.Length; j++)
                {
                    if (i < coins[j])
                    {
                        break;
                    }
                    if (lis[i - coins[j]] != int.MaxValue && lis[i - coins[j]] < max)
                    {
                        max = lis[i - coins[j]] + 1;
                    }
                }
                if (max != int.MaxValue)
                {
                    lis[i] = max;
                }
            }

            if (lis[^1] == int.MaxValue)
            {
                return -1;
            }
            else
            {
                return lis[^1];
            }
        }

        static int dp(int amount)
        {

            return 1;

        }


    }


}
