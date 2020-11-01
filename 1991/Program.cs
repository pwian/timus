using System;

namespace _1991
{
    class Program
    {
        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static long GetNumberLong()
        {
            return Convert.ToInt64(Console.ReadLine());
        }

        static int[] GetArrayInt()
        {
            string[] @string = Console.ReadLine().Split(' ');
            int[] array = new int[@string.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(@string[i]);
            }
            return array;
        }

        static long[] GetArrayLong()
        {
            string[] @string = Console.ReadLine().Split(' ');
            long[] array = new long[@string.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt64(@string[i]);
            }
            return array;
        }
        static void Main(string[] args)
        {
            int[] array = GetArrayInt();
            int n = array[0], k = array[1];
            array = GetArrayInt();
            int countUnused = 0;
            int countSurvived = 0;
            for (int i = 0; i < n; i++)
            {
                if (k > array[i])
                    countSurvived += k - array[i];
                else
                    countUnused += array[i] - k;
            }
            Console.WriteLine("{0} {1}", countUnused, countSurvived);
        }
    }
}
