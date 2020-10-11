using System;
using System.Collections.Generic;

namespace _1617
{
    class Program
    {
        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int n = GetNumberInt();
            Dictionary<int, int> car = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int k = GetNumberInt();
                if (car.ContainsKey(k))
                    car[k]++;
                else
                    car.Add(k, 1);
            }
            int countCar = 0;
            foreach (var item in car)
            {
                countCar += item.Value / 4;
            }
            Console.WriteLine(countCar);
        }
    }
}
