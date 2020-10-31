using System;

namespace _1877
{
    class Program
    {
        static void Main(string[] args)
        {
            int code1 = Convert.ToInt32(Console.ReadLine());
            int code2 = Convert.ToInt32(Console.ReadLine());
            if (code1 % 2 == 0 || code2 % 2 == 1)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}
