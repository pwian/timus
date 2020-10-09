using System;

namespace _1607
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
            int[] array = GetArrayInt();
            if (array[2] > array[0])
            {
                int count = (array[2] - array[0]) / (array[3] + array[1]);
                int prize1 = array[0] + array[1] * count;
                int prize2 = array[2] - array[3] * count;
                if (prize1 + array[1] <= prize2)
                    prize1 += array[1];
                else
                    prize1 = prize2;
                Console.WriteLine(prize1);
            }
            else
                Console.WriteLine(array[0]);
        }
    }
}
