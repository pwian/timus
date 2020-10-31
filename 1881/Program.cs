using System;

namespace _1881
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
            int[] array = GetArrayInt();
            int h = array[0], w = array[1], n = array[2];
            int countLine = 1;
            //int  = 0;
            int i = 0;
            int sumLengthLine = Console.ReadLine().Length;
            while (i < n - 1)
            {
                int lengthWord = Console.ReadLine().Length;
                i++;
                if (sumLengthLine + lengthWord + 1 <= w)
                {
                    sumLengthLine += lengthWord + 1;
                }
                else
                {
                    sumLengthLine = lengthWord;
                    countLine++;
                }
            }
            int countPage = countLine / h;
            if (countLine % h != 0)
                countPage++;
            Console.WriteLine(countPage);
        }
    }
}
