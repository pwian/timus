using System;

namespace _1349
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
            if (n == 0 || n > 2)
                Console.WriteLine("-1");
            else if (n == 1)
                Console.WriteLine("1 2 3");
            else
                Console.WriteLine("3 4 5");
        }
    }
}
