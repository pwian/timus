using System;

namespace _1293
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            Console.WriteLine(2 * Convert.ToInt32(line[0]) * Convert.ToInt32(line[1]) * Convert.ToInt32(line[2]));
        }
    }
}
