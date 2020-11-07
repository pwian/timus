using System;

namespace _2068
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
            int[] nuts = GetArrayInt();
            int sumStep = 0;
            for (int i = 0; i < nuts.Length; i++)
            {
                sumStep += nuts[i] / 2;
            }
            if (sumStep % 2 == 0)
                Console.WriteLine("Stannis");
            else
                Console.WriteLine("Daenerys");
        }
    }
}
