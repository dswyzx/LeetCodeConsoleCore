using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class TheThreeSum15_1
    {
        static void Main15_1(string[] args)
        {
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            var res = ThreeSum(nums);
        }

        static IList<IList<int>> ThreeSum(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int n = nums[j];
                        nums[j] = nums[i];
                        nums[i] = n;
                    }
                }
            }

            HashSet<int> l1 = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                l1.Add(nums[i]);
            }

            IList<IList<int>> list = new List<IList<int>>();
            if (l1.Count == 1 && l1.Contains(0) && nums.Length > 2)
            {
                list.Add(new List<int> { 0, 0, 0 });
                return list;
            }
            List<int> l2 = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                l2.Add(nums[i]);
            }
            HashSet<IntList> hs = new HashSet<IntList>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    if (nums[i] == nums[j] * -2)
                    {
                        if (nums[j] == nums[j + 1])
                        {
                            IntList a = new IntList(nums[i], nums[j], 0 - nums[i] - nums[j]);
                            hs.Add(a);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (l1.Contains(0 - nums[i] - nums[j]))
                    {
                        if ((0 - nums[i] - nums[j]) == nums[i])
                        {
                            continue;
                        }
                        IntList a = new IntList(nums[i], nums[j], 0 - nums[i] - nums[j]);
                        hs.Add(a);
                    }
                }
                if (nums[i] > 0)
                {
                    break;
                }

            }
            foreach (var item in hs)
            {
                list.Add(new List<int>() { item.a, item.b, item.c });
            }
            return list;


        }
    }
}
