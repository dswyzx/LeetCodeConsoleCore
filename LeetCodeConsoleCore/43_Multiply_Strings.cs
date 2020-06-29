using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class Multiply_Strings

    {
        static void Main43(string[] args)
        {
            string num1 = "321";
            string num2 = "321";
            var tes = Multiply(num1, num2);

        }

        static string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
            {
                return "0";
            }
            string res = "";
            int m = num1.Length;
            int n = num2.Length;
            List<int> li = new List<int>();
            for (int i = 0; i < m + n; i++)
            {
                li.Add(0);
            }

            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    int tmp = Convert.ToInt32(num1[i].ToString()) * Convert.ToInt32(num2[j].ToString());
                    int p1 = i + j;
                    tmp += li[p1 + 1];
                    li[p1] += tmp / 10;
                    li[p1 + 1] = tmp % 10;
                }
            }
            foreach (var item in li)
            {
                if (!string.IsNullOrEmpty(res) || item != 0)
                {
                    res += item.ToString();
                }
            }
            return res;
        }
    }
}
