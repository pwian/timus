using System;

namespace _1787
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

        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int k = Convert.ToInt32(line[0]);
            int n = Convert.ToInt32(line[1]);
            int[] a = GetArrayInt();
            int current = 0;
            for (int i = 0; i < a.Length; i++)
            {
                current += a[i] - k;
                if (current < 0)
                    current = 0;
            }

            Console.WriteLine(current);
        }
    }
}
