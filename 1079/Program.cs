using System;

namespace _1079
{
    class Program
    {

        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static int MaxFib(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            int[] number = new int[n + 1];
            number[0] = 0;
            number[1] = 1;
            int max = 1;
            for (int i = 2; i <= n; i++)
            {
                number[i] = number[i / 2];
                if (i % 2 != 0)
                    number[i] += number[i / 2 + 1];
                if (number[i] > max)
                    max = number[i];
            }
            return max;
        }

        static void Main(string[] args)
        {
            int n = GetNumberInt();
            while (n != 0)
            {
                Console.WriteLine(MaxFib(n));
                n = GetNumberInt();
            }

        }
    }
}
