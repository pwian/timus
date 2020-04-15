using System;

namespace _1068
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
                Console.WriteLine((1 + n) * n / 2);
            else if (n == 0)
                Console.WriteLine(1);
            else
                Console.WriteLine(n * (1 - n) / 2 + 1);
        }
    }
}
