using System;

namespace _1209
{
    class Program
    {       
        static long GetNumberLong()
        {
            return Convert.ToInt64(Console.ReadLine());
        }

        static int Num(long k)
        {
            if (k == 1 || k == 2)
                return 1;
            double D = Math.Sqrt(8 * k - 7);

            double root = (-3 + D) / 2;

            long r1 = (long)root, r2 = r1 + 1;

            if (k == (r1 * (r1 + 1) / 2 + r1 + 2) || k == (r2 * (r2 + 1) / 2 + r2 + 2))
                return 1;
            return 0;
        }

        static void Main(string[] args)
        {
            long n = GetNumberLong();
            long k;
            for (int i = 0; i < n - 1; i++)
            {
                k = GetNumberLong();
                Console.Write("{0} ", Num(k));
            }

            k = GetNumberLong();
            Console.Write("{0}", Num(k));
        }
    }
}
