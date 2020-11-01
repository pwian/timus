using System;

namespace _1935
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

        static ulong[] GetArrayULong()
        {
            string[] line = Console.ReadLine().Split(' ');
            ulong[] array = new ulong[line.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToUInt64(line[i]);
            }
            return array;
        }


        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static long GetNumberLong()
        {
            return Convert.ToInt64(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int n = GetNumberInt();
            int[] array = GetArrayInt();
            Array.Sort(array);
            int countPage = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                countPage += Math.Max(array[i], array[i + 1]);
            }
            countPage += array[array.Length - 1];
            Console.WriteLine(countPage);
        }
    }
}
