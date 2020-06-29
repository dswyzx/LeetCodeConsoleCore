using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class Letter_Combinations_of_a_Phone_Number
    {
        static void Main17(string[] args)
        {
            string nums = "22";
            var res = LetterCombinations1(nums);
        }
        public static IList<string> LetterCombinations(string digits)
        {
            if (digits.Length == 0)
            {
                return new List<string>() { "" };
            }
            string[] strdic = new string[] { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            List<string> list = new List<string>();
            list.Add("");
            foreach (char dig in digits.ToCharArray())
            {
                List<string> tmp = new List<string>();
                foreach (var item in list)
                {
                    string s = strdic[Convert.ToInt32(dig.ToString()) - 2];
                    for (int i = 0; i < s.Length; i++)
                    {
                        tmp.Add(item + s[i]);
                    }
                    list = tmp;
                }
            }
            return list;
        }

        public static IList<string> LetterCombinations1(string digits)
        {
            if (digits.Length == 0)
            {
                return new List<string>() { "" };
            }
            string[] strdic = new string[] { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            List<string> list = new List<string>();

            char[] cur = new char[digits.Length];

            dfs(digits, strdic, 0, cur, list);

            return list;
        }

        private static void dfs(string digits, string[] strdic, int l, char[] cur, List<string> list)
        {
            if (digits.Length == l)
            {
                if (l > 0)
                {
                    list.Add(new string(cur));
                    return;
                }
            }

            string s = strdic[Convert.ToInt32(digits[l].ToString()) - 2];

            for (int i = 0; i < s.Length; i++)
            {
                cur[l] = s[i];
                dfs(digits, strdic, l + 1, cur, list);
            }
        }
    }
}
