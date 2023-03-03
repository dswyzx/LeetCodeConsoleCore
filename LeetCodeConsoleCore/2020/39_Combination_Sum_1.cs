using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class Combination_Sum_1
    {
        static void Main39_1(string[] args)
        {
            int[] ins = new int[] { 3, 5, 7, 9 };

            var res = CombinationSum(ins, 8);
            res = CombinationSum1(ins, 8);
        }

        static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> res = new List<IList<int>>();
            for (int i = 0; i < candidates.Length; i++)
            {
                if (candidates[i] > target)
                {
                    break;
                }
                else if (candidates[i] == target)
                {
                    res.Add(new List<int>() { candidates[i] }); break;
                }

                List<int> last = new List<int>(candidates);
                last.RemoveRange(0, i);
                int[] lastint = last.ToArray();
                IList<IList<int>> tmp = CombinationSum(lastint, target - candidates[i]);

                for (int j = 0; j < tmp.Count; j++)
                {
                    tmp[j].Insert(0, candidates[i]);
                    IList<int> insert = new List<int>(tmp[j]);
                    res.Add(insert);
                }
            }
            return res;
        }

        static IList<IList<int>> CombinationSum1(int[] candidates, int target)
        {
            List<IList<IList<int>>> dp = new List<IList<IList<int>>>();

            for (int i = 1; i <= target; i++)
            {
                List<IList<int>> cur = new List<IList<int>>();
                for (int j = 0; j < candidates.Length; j++)
                {
                    if (candidates[j] > i)
                    {
                        break;
                    }
                    else if (candidates[j] == i)
                    {
                        cur.Add(new List<int>() { candidates[j] }); break;
                    }
                    foreach (var a in dp[i - candidates[j] - 1])
                    {
                        if (candidates[j] > a[0])
                        {
                            continue;
                        }
                        List<int> tmp = new List<int>(a);
                        tmp.Insert(0, candidates[j]);
                        cur.Add(tmp);
                    }
                }
                dp.Add(cur);
            }

            return dp[target - 1];

        }
    }


}
