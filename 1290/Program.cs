using System;
using System.Collections.Generic;

namespace _1290
{
    class Program
    {
        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static List<int> GetPrintArray(List<int> array)
        {
            List<int> print = new List<int>(25000);
            print.Add(array.Count);
            int countNumber = 0;
            int i = 0;
            int currentBiggerNumber = 1;
            while (i < array.Count)
            {
                while (i < array.Count && array[i] <= currentBiggerNumber)
                {
                    i++;
                    countNumber++;
                }
                print.Add(array.Count - countNumber);
                currentBiggerNumber++;
            }
            print.RemoveAt(print.Count - 1);
            return print;
        }

        static void PrintList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        static void Main(string[] args)
        {
            int n = GetNumberInt();
            List<int> array = new List<int>(n);
            for (int i = 0; i < n; i++)
            {
                array.Add(GetNumberInt());
            }
            for (int i = 0; i < 2; i++)
            {
                array.Sort();
                array = GetPrintArray(array);
            }
            PrintList(array);
        }
    }
}
