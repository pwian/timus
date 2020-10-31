using System;

namespace _1820
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(line[0]) * 2;
            int k = Convert.ToInt32(line[1]);
            int time = n / k;
            if (n % k != 0)
                time++;
            if (n <= 2 * k)
                time = 2;
            Console.WriteLine(time);
        }
    }
}
