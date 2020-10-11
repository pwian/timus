using System;

namespace _1636
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
            int t1 = array[0], t2 = array[1];
            array = GetArrayInt();
            int countErrowTime = 0;
            for (int i = 0; i < array.Length; i++)
            {
                countErrowTime += array[i];
            }
            if (t2 - countErrowTime * 20 < t1)
                Console.WriteLine("Dirty debug :(");
            else
                Console.WriteLine("No chance.");
        }
    }
}
