namespace LeetCodeConsoleCore
{
    class program_45Jump_Game_II
    {
        static void Main45(string[] args)
        {
            int[] nums = new int[] { 7, 0, 9, 6, 9, 6, 1, 7, 9, 0, 1, 2, 9, 0, 3 };//1, 2, 3
            var x = Jump(nums);
        }

        public static int Jump(int[] nums)
        {
            if (nums.Length == 1)
            {
                return 0;
            }
            if (nums[0] >= nums.Length - 1)
            {
                return 1;
            }
            int jumps = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] + i >= nums.Length)
                {
                    jumps++;
                    break;
                }
                int max = nums[i]; int add = 0;
                for (int j = 1; j <= nums[i]; j++)
                {
                    if (nums[i + j] + j >= max || i + j == nums.Length - 1)
                    {
                        add = j;
                        max = nums[i + j] + j;
                    }
                }
                i += add - 1;
                jumps++;
                if (i >= nums.Length - 2)
                {
                    break;
                }
            }
            return jumps;
        }
    }


}
