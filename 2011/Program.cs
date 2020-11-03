using System;

namespace _2011
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
            int[] array = GetArrayInt();
            int[] numbers = new int[4];
            int[] flag = new int[4];

            for (int i = 0; i < n; i++)
            {
                numbers[array[i]]++;
                flag[array[i]] = 1;

            }
            int countNumber = numbers[1] + numbers[2] + numbers[3];
            int countNumberFlag = flag[1] + flag[2] + flag[3];
            string answer = "No";
            if (countNumberFlag == 3)
                answer = "Yes";
            else if (countNumberFlag == 2)
            {
                if (n == 4 && (numbers[1] == 2 || numbers[2] == 2 || numbers[3] == 2))
                    answer = "Yes";
                if (n == 5 && (countNumberFlag == 3 || (numbers[1] == 2 || numbers[2] == 2 || numbers[3] == 2)))
                    answer = "Yes";
                if (n >= 6 && countNumberFlag >= 2)
                    answer = "Yes";
            }
            Console.WriteLine(answer);
        }
    }
}
