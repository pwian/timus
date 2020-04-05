using System;
using System.Collections.Generic;
using System.Numerics;

namespace _1009
{
    class Program
    {
        static long GetNumberLong()
        {
            return Convert.ToInt64(Console.ReadLine());
        }

        static long Remainder(long k, long n, long m)
        {
            BigInteger rem = new BigInteger();
            if (n == 0)
                rem = 1;
            else if (n == 1)
                rem = k % m;

            else if (n == 2)
                rem = ((BigInteger)k * k) % m;
            else if (n % 2 == 0)
            {
                rem = Remainder(k, n / 2, m);
                rem = (rem * rem) % m;
            }
            else
            {
                rem = Remainder(k, n - 1, m);
                rem = (k * rem) % m;
            }
            return (long)rem;
        }

        static Stack<int> Cmd(long n)
        {
            Stack<int> stack = new Stack<int>();
            while (n > 2)
            {
                if (n % 2 == 0)
                {
                    stack.Push(1);
                    n /= 2;
                }
                else
                {
                    stack.Push(0);
                    n -= 1;
                }
            }
            return stack;
        }

        static void Main(string[] args)
        {
            long n = GetNumberLong(), k = GetNumberLong();//, m = GetNumberLong();
            BigInteger a1 = k, a2 = (BigInteger)k * k - 1;
            if (n == 2)
                a2 = a1;
            else
            {
                a2 = (BigInteger)k * k - 1;
                a1 = k;
                Stack<int> cmd = Cmd(n - 1);                          //= 0 - +1;    =1 - * 2
                while (cmd.Count > 0)
                {
                    int op = cmd.Pop();
                    if (op == 1)
                    {
                        BigInteger buf = a2;
                        a2 = a2 * (k - 1) * a1 + (k - 1) * a1 * (buf - (k - 1) * a1);
                        a1 = a1 * (k - 1) * a1 + (buf - (k - 1) * a1) * (buf - (k - 1) * a1);
                    }
                    else
                    {
                        BigInteger buf = a2;
                        a2 = (k - 1) * (a2 + a1);
                        a1 = buf;
                    }
                }
            }
            a2 = (k - 1) * a2;  // % m;
            Console.WriteLine(a2);
        }
    }
}
