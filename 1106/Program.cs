using System;
using System.Collections.Generic;

namespace _1106
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

        static int Number(bool[] flag)
        {
            int i = 0;
            while (i < flag.Length && flag[i])
                i++;
            return i;
        }

        static void Main(string[] args)
        {
            int n = GetNumberInt();
            int[,] friends = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int[] array = GetArrayInt();
                for (int j = 0; j < array.Length - 1; j++)
                {
                    friends[i, array[j] - 1] = 1;
                    friends[array[j] - 1, i] = 1;
                }
            }

            var flag = new bool[n];
            var group = new List<int>();
            bool existFriend = false;

            while (true)
            {
                int i = Number(flag);
                if (i >= flag.Length)
                    break;
                group.Add(i);
                flag[i] = true;
                existFriend = false;
                for (int j = 0; j < n; j++)
                {
                    if (friends[i, j] == 1)
                    {
                        flag[j] = true;
                        existFriend = true;
                    }
                }
                if (!existFriend)
                    break;
            }

            if (!existFriend)
                Console.WriteLine("0");
            else
            {
                Console.WriteLine(group.Count);
                for (int i = 0; i < group.Count; i++)
                {
                    Console.Write("{0} ", group[i] + 1);
                }
            }
        }
    }
}
