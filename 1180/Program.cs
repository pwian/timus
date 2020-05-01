using System;
using System.Numerics;

namespace _1180
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] number = Console.ReadLine().ToCharArray();
            BigInteger n = new BigInteger();
            for (int i = 0; i < number.Length; i++)
            {
                n = n * 10 + number[i] - '0';
            }

            if (n % 3 == 0)
                Console.WriteLine("2");
            else
            {
                Console.WriteLine("1");
                Console.WriteLine(n % 3);

            }
        }
    }
}
