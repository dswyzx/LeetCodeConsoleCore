using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class four_sum
    {
        static void Main18(string[] args)
        {
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            var res = FourSum(nums, -1);
        }
        static IList<IList<int>> FourSum(int[] nums, int target)
        {
            if (nums.Length < 4)
            {
                return new List<IList<int>>();
            }
            IList<IList<int>> li = new List<IList<int>>();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int x = nums[i];
                        nums[i] = nums[j];
                        nums[j] = x;
                    }
                }
            }
            if (nums[0] == nums[nums.Length - 1] && nums[0] * 4 == target)
            {
                return new List<IList<int>>() { new List<int> { nums[0], nums[0], nums[0], nums[0] } };
            }
            for (int i = 0; i < nums.Length - 3; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }
                    int left = j + 1; int right = nums.Length - 1;
                    while (left < right)
                    {
                        int sum = nums[i] + nums[j] + nums[left] + nums[right];
                        if (sum == target)
                        {
                            List<int> l = new List<int>() { nums[i], nums[j], nums[left], nums[right] };
                            li.Add(l);
                            while (left < right && nums[left] == nums[left + 1])
                            {
                                left++;
                            }
                            while (left < right && nums[right] == nums[right - 1])
                            {
                                right--;
                            }
                            left++; right--;
                        }
                        else if (sum < target)
                        {
                            left++;
                        }
                        else
                        {
                            right--;
                        }
                    }
                }
            }

            return li;
        }


    }
}
