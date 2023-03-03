using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class Combination_Sum2
    {
        static void Main40(string[] args)
        {
            int[] ins = new int[] { 1, 1, 2, 5, 6, 7, 10 };

            var res = CombinationSum2(ins, 8);

        }

        static IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            IList<IList<int>> res = new List<IList<int>>();
            IList<int> once = new List<int>();
            Array.Sort(candidates);
            InDfs(0, candidates, target, once, res);
            return res;
        }

        private static void InDfs(int start, int[] candidates, int target, IList<int> once, IList<IList<int>> res)
        {
            if (target < 0)
            {
                return;
            }
            else if (target == 0)
            {
                IList<int> add = new List<int>(once);
                res.Add(add);
                return;
            }
            for (int i = start; i < candidates.Length && candidates[i] <= target; i++)
            {
                if (i != start && candidates[i] == candidates[i - 1])
                {
                    continue;
                }
                once.Add(candidates[i]);
                InDfs(i + 1, candidates, target - candidates[i], once, res);
                once.RemoveAt(once.Count - 1);
            }
        }
    }


}
