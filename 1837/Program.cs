using System;
using System.Collections.Generic;

namespace _1837
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

        static double[] GetArrayDouble()
        {
            string[] line = Console.ReadLine().Split(' ');
            double[] array = new double[line.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(line[i]);
            }
            return array;
        }

        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static double GetNumberDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        static void PrintAnswer(SortedList<string, int> list)
        {
            foreach (var item in list)
            {
                if (item.Value == -1)
                    Console.WriteLine("{0} {1}", item.Key, "undefined");
                else
                    Console.WriteLine("{0} {1}", item.Key, item.Value);
            }
        }

        static void Main(string[] args)
        {
            int n = GetNumberInt();
            int[,] matr = new int[3 * n, 3 * n];
            Dictionary<string, int> nameNumber = new Dictionary<string, int>();
            Dictionary<int, string> numberName = new Dictionary<int, string>();
            SortedList<string, int> answer = new SortedList<string, int>();
            int key = 0;
            for (int i = 0; i < n; i++)
            {
                string[] team = Console.ReadLine().Split(' ');
                for (int j = 0; j < 3; j++)
                {
                    if (!nameNumber.ContainsKey(team[j]))
                    {
                        nameNumber.Add(team[j], key);
                        numberName.Add(key, team[j]);
                        answer.Add(team[j], -1);
                        key++;
                    }
                }
                matr[nameNumber[team[0]], nameNumber[team[1]]] = 1;
                matr[nameNumber[team[0]], nameNumber[team[2]]] = 1;
                matr[nameNumber[team[1]], nameNumber[team[2]]] = 1;

                matr[nameNumber[team[1]], nameNumber[team[0]]] = 1;
                matr[nameNumber[team[2]], nameNumber[team[0]]] = 1;
                matr[nameNumber[team[2]], nameNumber[team[1]]] = 1;
            }
            if (nameNumber.ContainsKey("Isenbaev"))
            {
                Queue<int> queue = new Queue<int>();
                queue.Enqueue(nameNumber["Isenbaev"]);
                answer["Isenbaev"] = 0;
                int count;
                while (queue.Count > 0)
                {
                    int k = queue.Dequeue();
                    count = answer[numberName[k]] + 1;
                    for (int i = 0; i < key; i++)
                    {
                        if (i != k && answer[numberName[i]] == -1 && (matr[k, i] == 1 || matr[i, k] == 1))
                        {
                            if (answer[numberName[i]] == -1)
                                answer[numberName[i]] = count;
                            queue.Enqueue(i);
                        }
                    }

                }
            }
            PrintAnswer(answer);
        }
    }
}
