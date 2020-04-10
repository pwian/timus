using System;
using System.Numerics;

namespace _1012
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = Convert.ToUInt32(Console.ReadLine());
            uint k = Convert.ToUInt32(Console.ReadLine());
            BigInteger a1 = k * (k - 1), a2 = k * k - 1;

            if (n == 2)
            {
                Console.WriteLine(a1);
            }
            else
            {
                long i = 3;
                BigInteger buf;
                checked
                {
                    while (i < n)
                    {
                        buf = (k - 1) * a2 + a1;
                        a1 = (k - 1) * a2;
                        a2 = buf;
                        i++;
                    }
                }
                a2 = (k - 1) * a2;
                Console.WriteLine(a2);
            }
        }
    }
}
