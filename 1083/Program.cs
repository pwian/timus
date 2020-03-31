using System;

namespace _1083
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(line[0]);
            int k = line[1].Length;
            int result = n;
            while (n > 0)
            {
                n -= k;
                if (n > 0)
                    result *= n;
            }
            Console.WriteLine(result);
        }
    }
}
