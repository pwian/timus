using System;

namespace _1876
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
            int[] array = GetArrayInt();
            int a = array[0], b = array[1];
            int count1 = 40 + 2 * (a - 40) + 39 * 2 + 1;
            int count2 = b * 2 + 40;

            Console.WriteLine(Math.Max(count1, count2));
        }
    }
}
