using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class Divide_Two_Integers
    {
        static void Main29(string[] args)
        {
            int a = int.MinValue;
            int res = Divide(2147483647, 3);
        }

        static int Divide(int dividend, int divisor)
        {
            if (divisor == 1)
            {
                return dividend;
            }
            else if (divisor == -1)
            {
                if (dividend == -2147483648)
                {
                    return 2147483647;
                }
                else
                {
                    return 0 - dividend;
                }
            }
            bool f = false;
            long a = 0; long b = 0;
            if (dividend < 0)
            {
                f = !f;
                a = (long)0 - dividend;
            }
            else
            {
                a = dividend;
            }
            if (divisor < 0)
            {
                f = !f;
                b = (long)0 - divisor;
            }
            else
            {
                b = divisor;
            }
            int res = 0;

            long m = 1; long n = b;
            while (a >= b)
            {
                while (a >= n << 1)
                {
                    n <<= 1;
                    m <<= 1;
                }
                if (a < n)
                {
                    n >>= 1;
                    m >>= 1;
                }
                if (a < n)
                {
                    continue;
                }
                a -= n;
                res += (int)m;
            }
            if (f)
            {
                res = 0 - res;
            }
            return res;
        }
    }

}
