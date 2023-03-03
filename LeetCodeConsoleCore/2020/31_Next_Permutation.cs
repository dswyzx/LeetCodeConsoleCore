using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class Next_Permutation
    {
        static void Main31(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4 };
            NextPermutation(nums);
        }

        static void NextPermutation(int[] nums)
        {
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i + 1] > nums[i])
                {
                    for (int j = nums.Length - 1; j >= 0; j--)
                    {
                        if (nums[j] > nums[i])
                        {
                            int x = nums[i];
                            nums[i] = nums[j];
                            nums[j] = x;
                            break;
                        }
                    }
                    Array.Reverse(nums, i + 1, nums.Length - i - 1);
                    return;
                }
            }
            Array.Sort(nums);
        }
        public static void NextPermutation1(int[] nums)
        {
            var i = nums.Length - 2;
            while (i >= 0 && nums[i + 1] <= nums[i])
                i--;

            if (i >= 0)
            {
                var j = nums.Length - 1;
                while (j >= 0 && nums[j] <= nums[i])
                { j--; }

                var temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }

            Array.Reverse(nums, i + 1, nums.Length - i - 1);
        }

        public static void NextPermutation2(int[] nums)
        {
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i + 1] > nums[i])
                {
                    if (i >= 0)
                    {
                        var j = nums.Length - 1;
                        while (j >= 0 && nums[j] <= nums[i])
                        { j--; }

                        var temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                    Array.Reverse(nums, i + 1, nums.Length - i - 1);
                    return;
                }
            }
            Array.Sort(nums);
        }
    }


}
