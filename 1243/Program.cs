using System;
using System.Numerics;

namespace _1243
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger count;
            BigInteger.TryParse(Console.ReadLine(), out count);

            Console.WriteLine(count % 7);
        }
    }
}
