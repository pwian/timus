using System;

namespace _1493
{
    class Program
    {
        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static bool Lucky(int n)
        {
            int s1 = n % 1000;
            int s2 = n / 1000;
            s1 = s1 % 10 + s1 / 100 + (s1 / 10) % 10;
            s2 = s2 % 10 + s2 / 100 + (s2 / 10) % 10;
            return s1 == s2;
        }

        static void Main(string[] args)
        {
            int n = GetNumberInt();
            if (Lucky(n - 1) || Lucky(n + 1))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
