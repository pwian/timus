using System;

namespace _1196
{
    class Program
    {
        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
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
            int n = GetNumberInt();
            int[] prof = new int[n];
            for (int i = 0; i < n; i++)
            {
                prof[i] = GetNumberInt();
            }
            int m = GetNumberInt();
            int count = 0;
            for (int i = 0; i < m; i++)
            {
                if (Contains(prof, GetNumberInt()))
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
