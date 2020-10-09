using System;

namespace _1502
{
    class Program
    {
        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int n = GetNumberInt();
            long a1 = (1 + n) * n / 2;
            long countDiamond = a1;
            for (int i = 1; i <= n; i++)
            {
                a1 = (i + n) * (n - i + 1) / 2;
                countDiamond += a1 + i * (n - i + 1);
            }
            Console.WriteLine(countDiamond);
        }
    }
}
