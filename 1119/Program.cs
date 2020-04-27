using System;

namespace _1119
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

        static int[] CopyArray(int[] array)
        {
            int[] b = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                b[i] = array[i];
            }
            return b;
        }

        static void Main(string[] args)
        {
            int[] array = GetArrayInt();
            int n = array[0], m = array[1];
            int k = GetNumberInt();
            int[,] matr = new int[m, n];
            for (int i = 0; i < k; i++)
            {
                array = GetArrayInt();
                matr[array[1] - 1, array[0] - 1] = 1;
            }

            array = new int[n + 1];

            for (int i = 0; i < m; i++)
            {
                int max = 0;
                int[] b = CopyArray(array);
                array[0] = 0;
                for (int j = 1; j <= n; j++)
                {
                    if (b[j - 1] > max)
                        max = b[j - 1];
                    if (matr[i, j - 1] == 0)
                        array[j] = max;
                    else
                        array[j] = max + 1;
                    array[j] = Math.Max(array[j - 1], Math.Max(array[j], b[j]));
                }

            }

            int diagMax = array[n];

            int dist = (int)Math.Round(100 * (diagMax * Math.Sqrt(2) + (m + n - 2 * diagMax)));
            Console.WriteLine(dist);
        }
    }
}
