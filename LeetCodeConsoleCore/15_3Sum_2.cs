using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class TheThreeSum15_2
    {
        static void Main15_2(string[] args)
        {
            int[] nums = new int[] { -1, 0, 1, -1, 2, -1 };
            var res = ThreeSum(nums);
        }

        static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();
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
            if (nums.Length > 2 && nums[0] == 0 && nums[nums.Length - 1] == 0)
            {
                list.Add(new List<int> { 0, 0, 0 });
                return list;
            }
            HashSet<string> hstr = new HashSet<string>();
            for (int i = 1; i < nums.Length - 1; i++)
            {
                int left = i - 1; int right = i + 1;
                while (left >= 0 || right <= nums.Length - 1)
                {
                    if (nums[left] + nums[i] + nums[right] == 0)
                    {
                        string str = nums[left] + "," + nums[i] + "," + nums[right];
                        hstr.Add(str);
                        left--;
                        if (left < 0)
                        {
                            break;
                        }
                    }
                    else if ((nums[left] + nums[i] + nums[right] > 0) && nums[0] < 0)
                    {
                        left--;
                        if (left < 0)
                        {
                            break;
                        }
                    }
                    else if ((nums[left] + nums[i] + nums[right] < 0) && nums[nums.Length - 1] > 0)
                    {
                        right++;
                        if (right > nums.Length - 1)
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            foreach (var str in hstr)
            {
                string[] ints = str.Split(',');
                list.Add(new List<int>() { int.Parse(ints[0]), int.Parse(ints[1]), int.Parse(ints[2]) });
            }
            return list;
        }
    }
}
