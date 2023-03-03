using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class program_38Count_and_Say
    {
        static void Main38(string[] args)
        {
            var x = CountAndSay(6);
        }

        static string CountAndSay(int n)
        {
            if (n == 1)
            {
                return "1";
            }
            string old = CountAndSay(n - 1);
            StringBuilder res = new StringBuilder();

            char sorce = old[0];
            int len = 1;
            for (int i = 1; i < old.Length; i++)
            {
                if (sorce == old[i])
                {
                    len++;
                }
                else
                {
                    res.Append(len.ToString() + sorce);
                    sorce = old[i];
                    len = 1;
                }
            }
            res.Append(len.ToString() + sorce);
            return res.ToString();
        }
    }




}
