using System;
using System.Text;

namespace LeetCodeConsoleCore
{
    class Container_With_Most_Water
    {
        static void Main11(string[] args)
        {
            int[] input = new int[] { 2, 3, 4, 5, 18, 17, 6 };
            int res = MaxArea(input);

        }

        public static int MaxArea(int[] height)
        {
            if (height.Length < 2) { return 0; }
            int left = 0; int right = height.Length - 1;
            int result = 0;
            while (left < right)
            {
                int themax = max(height, left, right);
                if (result < themax)
                {
                    result = themax;
                }
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return result;
        }

        private static int max(int[] height, int left, int right)
        {
            if (left >= right)
            {
                return 0;
            }
            int hei = height[left] < height[right] ? height[left] : height[right];

            return hei * (right - left);
        }
    }
}
