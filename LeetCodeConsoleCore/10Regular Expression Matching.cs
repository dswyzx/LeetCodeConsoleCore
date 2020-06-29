using System;
using System.Text;

namespace LeetCodeConsoleCore
{
    class Regular_Expression_Matching
    {
        static void Main10(string[] args)
        {
            string s = "aa";
            string p = "a*a";
            bool res = IsMatch(s, p);

        }

        public static bool IsMatch(string s, string p)
        {
            if (p.Length == 0)
            {
                return s.Length == 0;
            }
            if (p.Length == 1)
            {
                return s == p || (s.Length == 1 && p == ".");
            }
            if (p[1] != '*')
            {
                if (s.Length == 0)
                {
                    return false;
                }
                return (s[0] == p[0] || p[0] == '.') && (IsMatch(s.Substring(1), p.Substring(1)));
            }
            while (s.Length > 0 && (s[0] == p[0] || p[0] == '.'))
            {
                if (IsMatch(s, p.Substring(2)))
                {
                    return true;
                }
                else
                {
                    s = s.Substring(1);
                }
            }
            return IsMatch(s, p.Substring(2));
        }
    }
}
