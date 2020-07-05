using System;

namespace _1409
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');

            Console.WriteLine("{0} {1}", Convert.ToInt32(line[1]) - 1, Convert.ToInt32(line[0]) - 1);
        }
    }
}
