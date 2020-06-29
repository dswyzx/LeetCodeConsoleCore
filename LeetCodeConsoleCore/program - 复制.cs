using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3 };

            var res = Permute(a);
        }


        static IList<IList<int>> Permute(int[] nums)
        {
            List<IList<int>> res = new List<IList<int>>();
            int[] visited = new int[nums.Length];
            IList<int> once = new List<int>();
            DfsDeep(nums, once, res, 0, visited);
            return res;
        }

        private static void DfsDeep(int[] nums, IList<int> once, List<IList<int>> res, int start, int[] visited)
        {
            if (start == nums.Length)
            {
                IList<int> add = new List<int>(once);
                res.Add(add);
                //once.Clear();
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (visited[i] == 1)
                {
                    continue;
                }
                visited[i] = 1;
                once.Add(nums[i]);
                DfsDeep(nums, once, res, start + 1, visited);
                once.RemoveAt(once.Count - 1);
                visited[i] = 0;
            }
        }
    }


}
