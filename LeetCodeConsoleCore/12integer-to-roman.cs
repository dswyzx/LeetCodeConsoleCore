using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class integer_to_roman
    {
        static void Main12(string[] args)
        {

            int res = 1999;
            string roman = IntToRoman(res);

        }
        static string IntToRoman(int num)
        {
            string res = "";
            int thenum = 0;
            if (num > 4000)
            {
                return "";
            }
            if (num >= 1000)
            {
                thenum = num / 1000;
                res += add(thenum, "M");
                num -= thenum * 1000;
            }
            if (num >= 100)
            {
                thenum = num / 100;
                res += add(thenum, "C", "D", "M");
                num -= thenum * 100;
            }
            if (num >= 10)
            {
                thenum = num / 10;
                res += add(thenum, "X", "L", "C");
                num -= thenum * 10;
            }
            if (num >= 1)
            {
                thenum = num;
                res += add(thenum, "I", "V", "X");
            }
            return res;
        }

        static string add(int num, string addless3, string add5 = "", string add10 = "")
        {
            string res = "";

            if (num <= 3)
            {
                for (int i = 0; i < num; i++)
                {
                    res += addless3;
                }
            }
            else if (num == 4)
            {
                res += addless3 + add5;
            }
            else if (num < 9)
            {
                res += add5;
                for (int i = 0; i < num - 5; i++)
                {
                    res += addless3;
                }
            }
            else
            {
                res += addless3 + add10;
            }
            return res;
        }


    }
}
