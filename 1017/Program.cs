using System;

namespace _1017
{
    class Program
    {
        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static long SumTo(long[,] matr, int i, int j)
        {
            long count = 0;
            if (i <= j)
                return count;
            for (int k = 1; k <= j; k++)
            {
                count += matr[i, k];
            }
            return count;
        }

        static void Main(string[] args)
        {
            int n = GetNumberInt();

            long[,] countStairCase = new long[n + 1, n + 1];
            for (int i = 0; i < n + 1; i++)
            {
                countStairCase[i, i] = 1;
            }
            countStairCase[1, 1] = 1;
            countStairCase[2, 2] = 1;

            countStairCase[3, 3] = 2;
            countStairCase[3, 2] = 1;

            countStairCase[4, 4] = 2;
            countStairCase[4, 3] = 1;

            for (int i = 5; i <= n; i++)
            {
                int middle = i / 2;
                if (i % 2 == 0)
                    middle--;
                for (int j = 1; j <= middle; j++)
                {
                    countStairCase[i, i] += countStairCase[j, j];
                    countStairCase[i, i - j] += countStairCase[j, j];
                }
                int sq = (int)((-1 + Math.Sqrt(1 + 8 * i)) / 2);
                for (int j = middle + 1; j <= i - sq; j++)
                {
                    long sum = SumTo(countStairCase, j, i - j - 1);
                    countStairCase[i, i] += sum;
                    countStairCase[i, i - j] += sum;
                }
            }

            Console.WriteLine(countStairCase[n, n] - 1);
        }
    }
}
