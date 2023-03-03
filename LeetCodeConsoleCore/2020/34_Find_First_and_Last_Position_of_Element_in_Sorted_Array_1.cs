using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class Find_First_and_Last_Position_of_Element_in_Sorted_Array_1
    {
        static void Main34_1(string[] args)
        {
            int[] nums = new int[] { 8 };

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
                    left = right = mid;
                    break;
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
            if (nums[left] != target)
            {
                return new int[] { -1, -1 };
            }
            while (left >= 0 && nums[left] == target)
            {
                left--;
            }
            while (right <= nums.Length - 1 && nums[right] == target)
            {
                right++;
            }

            return new int[] { left + 1, right - 1 };
        }

    }


}
