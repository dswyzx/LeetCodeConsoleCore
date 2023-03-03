using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class TheThreeSum15
    {
        static void Main15(string[] args)
        {
            int[] nums = new int[] { -1, 0, 1 ,-1,2,-1};
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
            HashSet<IntList> hs = new HashSet<IntList>();
            for (int i = 1; i < nums.Length - 1; i++)
            {
                int left = i - 1; int right = i + 1;
                while (left >= 0 || right <= nums.Length - 1)
                {
                    if (nums[left] + nums[i] + nums[right] == 0)
                    {
                        IntList a = new IntList(nums[left], nums[i], nums[right]);
                        hs.Add(a);
                        left--;
                    }
                    else if (nums[left] + nums[i] + nums[right] > 0)
                    {
                        left--;
                    }
                    else
                    {
                        right++;
                        if (right > nums.Length - 1)
                        {
                            break;
                        }
                    }

                    if (left < 0)
                    {
                        break;
                    }

                }
            }
            foreach (var item in hs)
            {
                list.Add(new List<int>() { item.a, item.b, item.c });
            }
            return list;


        }
    }

    public class IntList
    {
        public IntList(int _a, int _b, int _c)
        {
            a = _a;
            b = _b;
            c = _c;
        }
        public int a;
        public int b;
        public int c;
        public override bool Equals(object o)
        {
            if (o is IntList s)
            {
                IntList t = (IntList)o;
                return t.a == s.a && t.b == s.b && t.c == s.c;
            }

            else { return false; }
        }
        public override int GetHashCode()
        {
            int t = 0;
            if (a > b) { t = a; a = b; b = t; }
            if (a > c) { t = a; a = c; c = t; }
            if (b > c) { t = b; b = c; c = t; }
            return (a.ToString() + b.ToString() + c.ToString()).GetHashCode();
        }

    }
}
