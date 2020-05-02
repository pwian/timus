using System;

namespace _1194
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

        static int[] GetArrayToInt(string str)
        {
            string[] line = str.Split(' ');
            int[] array = new int[line.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(line[i]);
            }
            return array;
        }

        static int CountHandOneLine(int[] array)
        {
            int countGroup = array[1];
            int internalSum = array[array.Length - 1];
            int countHand = 0;
            for (int i = 1; i < countGroup; i++)
            {
                countHand += array[array.Length - 1 - 2 * i] * internalSum;
                internalSum += array[array.Length - 1 - 2 * i];
            }
            return countHand;
        }

        static void Main(string[] args)
        {
            _ = GetArrayInt();
            string[] text = Console.In.ReadToEnd().Split('\n');
            int countHand = 0;
            for (int i = 0; i < text.Length - 1; i++)
            {
                int[] array = GetArrayToInt(text[i]);
                countHand += CountHandOneLine(array);
            }
            Console.WriteLine(countHand);
        }
    }
}
