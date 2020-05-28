using System;

namespace _1327
{
    class Program
    {
        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int day1 = GetNumberInt();
            int day2 = GetNumberInt();
            int count = (day2 + 1) / 2 - day1 / 2;
            Console.WriteLine(count);
        }
    }
}
