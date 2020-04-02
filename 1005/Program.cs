using System;

namespace _1005
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

        static int DivMin(int[] w, int fullSum, int currentSum, int k)
        {
            if (k >= w.Length - 1)
                return Math.Abs(fullSum - 2 * currentSum);
            if (2 * currentSum >= fullSum)
                return Math.Abs(fullSum - 2 * currentSum);
            return Math.Min(DivMin(w, fullSum, currentSum + w[k], k + 1), DivMin(w, fullSum, currentSum, k + 1));
        }

        static void Main(string[] args)
        {
            int n = GetNumberInt();
            int[] w = GetArrayInt();
            Array.Sort(w);
            int fullSum = 0; int sum2 = 0;
            for (int i = 0; i < w.Length; i++)
            {
                fullSum += w[i];
            }
            int d = DivMin(w, fullSum, 0, 0);
            Console.WriteLine(d);
        }
    }
}
