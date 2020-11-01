using System;

namespace _2001
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
            int[] a1 = GetArrayInt();
            int[] a2 = GetArrayInt();
            int[] a3 = GetArrayInt();


            Console.WriteLine("{0} {1}", a1[0] - a3[0], a1[1] - a2[1]);

        }
    }
}
