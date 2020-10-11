using System;

namespace _1639
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
            int[] a = GetArrayInt();
            if ((a[0] * a[1] - 1) % 2 == 0)
                Console.WriteLine("[second]=:]");
            else
                Console.WriteLine("[:=[first]");
        }
    }
}
