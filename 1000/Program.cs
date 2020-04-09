using System;

namespace _1000
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(str[0]);
            int b = Convert.ToInt32(str[1]);
            Console.WriteLine(a + b);
        }
    }
}
