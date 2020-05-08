using System;

namespace _1264
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(line[0]);
            int m = Convert.ToInt32(line[1]);

            Console.WriteLine(n * (m + 1));
        }
    }
}
