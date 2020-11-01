using System;

namespace _1910
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
            int[] a = GetArrayInt();
            int max = a[0] + a[1] + a[2];
            int middle = 1;
            for (int i = 2; i < a.Length - 1; i++)
            {
                int sum = a[i - 1] + a[i] + a[i + 1];
                if (sum > max)
                {
                    max = sum;
                    middle = i;
                }
            }
            Console.WriteLine("{0} {1}", max, middle + 1);
        }
    }
}
