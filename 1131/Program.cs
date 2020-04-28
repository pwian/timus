using System;

namespace _1131
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
            int n = array[0], k = array[1];

            int time = 0;
            int currentCountModem = 1;
            int countComputer = 1;
            while (currentCountModem < k && countComputer < n)
            {
                time++;
                countComputer += currentCountModem;
                currentCountModem = countComputer;
            }
            if (countComputer < n)
            {
                time += (n - countComputer) / k;
                if ((n - countComputer) % k != 0)
                    time++;
            }
            Console.WriteLine(time);

        }
    }
}
