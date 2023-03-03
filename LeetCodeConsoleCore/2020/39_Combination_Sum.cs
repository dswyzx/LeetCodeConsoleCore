using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class Combination_Sum
    {
        static void Main39(string[] args)
        {

            int[] ins = new int[] { 2, 3, 5, 7 };

            var res = CombinationSum(ins, 8);
        }


        static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> res = new List<IList<int>>();
            IList<int> once = new List<int>();
            CombinDFS(0, candidates, target, once, res);
            return res;
        }

        private static void CombinDFS(int start, int[] candidates, int target, IList<int> once, IList<IList<int>> res)
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
            for (int i = start; i < candidates.Length; i++)
            {
                once.Add(candidates[i]);
                CombinDFS(i, candidates, target - candidates[i], once, res);
                once.RemoveAt(once.Count - 1);
            }
        }
    }


}
