using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class Search_in_Rotated_Sorted_Array
    {
        static void Main33(string[] args)
        {
            int[] nums = new int[] { 1,3 };
            int n = Search(nums,3);

        }

        static int Search(int[] nums, int target)
        {
            if (nums.Length == 0) { return -1; }
            if (target < nums[0] && target > nums[nums.Length - 1])
            {
                return -1;
            }

            int left = 0; int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                if (nums[mid] >= nums[left])
                {
                    if (target < nums[mid] && target >= nums[left])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;

                    }
                }
                else
                {
                    if (target > nums[mid] && target <= nums[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }

            }
            return -1;
        }

    }


}
