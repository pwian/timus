using System;

namespace _2066
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
            int a = GetNumberInt();
            int b = GetNumberInt();
            int c = GetNumberInt();
            if (b == 0)
                Console.WriteLine(a - b - c);
            else if (b == 1)
                Console.WriteLine(a - b - c);
            else
                Console.WriteLine(a - b * c);
        }
    }
}
