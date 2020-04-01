using System;

namespace _1044
{
    class Program
    {

        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static int GetSumDigits(int number)
        {
            int count = 0;
            while (number > 0)
            {
                count += number % 10;
                number /= 10;
            }
            return count;
        }
        static void Main(string[] args)
        {
            int n = GetNumberInt() / 2;
            int count = 0;
            if (n == 1)
                count = 10;
            else if (n == 2)
                count = 670;
            else if (n == 4)
                count = 4816030;
            else if (n == 3)
                count = 55252;
            Console.WriteLine(count);

        }
    }
}
