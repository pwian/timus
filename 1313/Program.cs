using System;

namespace _1313
{
    class Program
    {
        static int[] GetArrayInt()
        {
            string[] line = Console.ReadLine().Split(' ');
            int[] array = new int[line.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(line[i]);
            }
            return array;
        }

        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int n = GetNumberInt();
            int[,] matr = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int[] array = GetArrayInt();
                for (int j = 0; j < n; j++)
                {
                    matr[i, j] = array[j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.Write("{0} ", matr[j, i - j]);
                }
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write("{0} ", matr[n - 1 + i - j, j]);
                }
            }

        }
    }
}
