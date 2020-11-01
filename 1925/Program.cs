using System;

namespace _1925
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

        static double[] GetArrayDouble()
        {
            string[] line = Console.ReadLine().Split(' ');
            double[] array = new double[line.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(line[i]);
            }
            return array;
        }

        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static double GetNumberDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        static bool Contains(int[] prof, int k)
        {
            int l = 0, r = prof.Length - 1;
            int mid;

            while (l < r)
            {
                mid = (l + r + 1) / 2;
                if (prof[mid] > k)
                    r = mid - 1;
                else
                    l = mid;
            }

            return prof[l] == k;
        }
        static void Main(string[] args)
        {
            int[] array = GetArrayInt();
            int n = array[0], k = array[1];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                array = GetArrayInt();
                sum += array[0] - array[1] - 2;
            }
            sum = k - 2 + sum;
            if (sum >= 0)
                Console.WriteLine(sum);
            else
                Console.WriteLine("Big Bang!");
        }
    }
}
