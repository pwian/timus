using System;
using System.Collections.Generic;

namespace _1086
{
    class Program
    {
        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static int NextPrime(List<int> list)
        {
            if (list == null || list.Count == 0)
                return 2;
            if (list.Count == 1)
                return 3;
            int number = list[list.Count - 1] + 2;
            while (true)
            {
                int i = 0;
                bool flag = true;
                while (i < list.Count && list[i] * list[i] <= number)
                {
                    if (number % list[i] == 0)
                    {
                        flag = false;
                        break;
                    }
                    i++;
                }
                if (flag)
                    break;
                number += 2;
            }
            return number;
        }

        static List<int> Prime(int n)
        {
            List<int> list = new List<int>(n);
            for (int i = 0; i < n; i++)
            {
                int number = NextPrime(list);
                list.Add(number);
            }
            return list;
        }

        static void Main(string[] args)
        {
            List<int> prime = Prime(15000);
            int k = GetNumberInt();
            for (int i = 0; i < k; i++)
            {
                int n = GetNumberInt();
                Console.WriteLine(prime[n - 1]);
            }
        }
    }
}
