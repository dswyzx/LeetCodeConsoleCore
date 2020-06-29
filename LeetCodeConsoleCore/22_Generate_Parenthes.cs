using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class Generate_Parenthes
    {
        static void Main22(string[] args)
        {
            var x = GenerateParenthesis(3);
        }

        static IList<string> GenerateParenthesis(int n)
        {
            HashSet<string> hs = new HashSet<string>();
            if (n == 0)
            {
                return new List<string> { "" };
            }
            else
            {
                IList<string> res = GenerateParenthesis(n - 1);
                foreach (var item in res)
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (item[i] == '(')
                        {
                            string newstr = item.Insert(i + 1, "()");
                            hs.Add(newstr);
                        }
                    }
                    hs.Add("()" + item);
                }
            }
            return new List<string>(hs);
        }
    }


}
