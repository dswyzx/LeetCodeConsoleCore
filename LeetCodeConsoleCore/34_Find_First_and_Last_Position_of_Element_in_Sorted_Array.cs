using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class Find_First_and_Last_Position_of_Element_in_Sorted_Array
    {
        static void Main34(string[] args)
        {
            int[] nums = new int[] { 5, 7, 7, 8, 8, 10 };

            var res = SearchRange(nums, 8);
        }
        static int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return new int[] { -1, -1 };
            }
            int left = 0; int right = nums.Length - 1;
            if (nums[left] > target || nums[right] < target)
            {
                return new int[] { -1, -1 };
            }
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == target)
                {
                    if (nums[left] < target)
                    {
                        left = left + 1;
                    }
                    if (nums[right] > target)
                    {
                        right = right - 1;
                    }
                    if (nums[left] == nums[right])
                    {
                        return new int[] { left, right };
                    }
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return new int[] { -1, -1 };
        }

    }


}
