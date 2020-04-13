using System;
using System.Threading;
using System.Globalization;

namespace _1020
{
    class Program
    {
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

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string[] strNumb = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(strNumb[0]);
            double r = Convert.ToDouble(strNumb[1]);
            double[,] heads = new double[n, 2];

            for (int i = 0; i < n; i++)
            {
                double[] arrayDouble = GetArrayDouble();
                heads[i, 0] = arrayDouble[0];
                heads[i, 1] = arrayDouble[1];
            }

            double sumLength;
            if (n == 1)
                sumLength = 2 * Math.PI * r;
            else if (n == 2)
                sumLength = 2 * Math.PI * r + 2 * Math.Sqrt(Math.Pow(heads[0, 0] - heads[1, 0], 2) + Math.Pow(heads[0, 1] - heads[1, 1], 2));
            else
            {
                sumLength = Math.PI * r * (4 - 2) + Math.Sqrt(Math.Pow(Math.Abs(heads[0, 0] - heads[n - 1, 0]), 2) + Math.Pow(Math.Abs(heads[0, 1] - heads[n - 1, 1]), 2));
                for (int i = 1; i < n; i++)
                {
                    sumLength += Math.Sqrt(Math.Pow(Math.Abs(heads[i - 1, 0] - heads[i, 0]), 2) + Math.Pow(Math.Abs(heads[i - 1, 1] - heads[i, 1]), 2));
                }
            }
            Console.WriteLine("{0:F2}", sumLength);


        }
    }
}
