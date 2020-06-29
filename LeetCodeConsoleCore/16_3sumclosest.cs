using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class sumclosest
    {
        static void Main16(string[] args)
        {
            int[] nums = new int[] { -1, 2, 1, -4 };
            var res = ThreeSumClosest(nums, 1);
        }

        static int ThreeSumClosest(int[] nums, int target)
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

            int deff = Math.Abs(nums[0] + nums[1] + nums[2] - target);

            int result = nums[0] + nums[1] + nums[2];

            for (int i = 1; i < nums.Length - 1; i++)
            {
                int left = i - 1; int right = i + 1;


                while (left >= 0 && right <= nums.Length - 1)
                {
                    int sub = Math.Abs(nums[i] + nums[left] + nums[right] - target);
                    if (sub < deff)
                    {
                        deff = sub;
                        result = nums[i] + nums[left] + nums[right];
                    }
                    if ((nums[i] + nums[left] + nums[right] - target) > 0)
                    {
                        left--;
                    }
                    else
                    {
                        right++;
                    }

                }

            }

            return result;
        }
    }
}
