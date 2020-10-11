using System;

namespace _1638
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
            int routeLength = (Math.Abs((array[3] - array[2])) - 1) * (array[0] + 2 * array[1]);
            if (routeLength < 0)
                routeLength = 0;
            if (array[3] > array[2])
                routeLength += 2 * array[1];
            else if (array[3] == array[2])
                routeLength += array[0];
            else
                routeLength += 2 * array[0] + 2 * array[1];
            Console.WriteLine(routeLength);
        }
    }
}
