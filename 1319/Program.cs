using System;

namespace _1319
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
            int[,] matr = new int[n, n];
            int number = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    matr[j, n + j - i - 1] = number++;
                }
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j + i < n; j++)
                {
                    matr[j + i, j] = number++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", matr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
