using System;

namespace _1893
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
            string place = Console.ReadLine();
            char c = place[place.Length - 1];
            int row = Convert.ToInt32(place.Remove(place.Length - 1));
            place = "neither";
            if (row <= 2)
                if (c == 'A' || c == 'D')
                    place = "window";
                else
                    place = "aisle";
            else if (row <= 20)
            {
                if (c == 'A' || c == 'F')
                    place = "window";
                else if (c == 'C' || c == 'D' || c == 'B' || c == 'E')
                    place = "aisle";
            }
            else if (c == 'A' || c == 'K')
                place = "window";
            else if (c == 'D' || c == 'C' || c == 'G' || c == 'H')
                place = "aisle";
            Console.WriteLine(place);
        }
    }
}
