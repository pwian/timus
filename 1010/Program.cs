using System;

namespace _1010
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
            long n = GetNumberInt();
            long[] func = new long[n];
            for (int i = 0; i < n; i++)
            {
                func[i] = GetNumberInt();
            }
            long left = 0, right = 1, koef = Math.Abs(func[left] - func[right]);
            for (int i = 1; i < n - 1; i++)
            {
                if (Math.Abs(func[i] - func[i + 1]) > koef)
                {
                    koef = Math.Abs(func[i] - func[i + 1]);
                    left = i;
                    right = i + 1;
                }
            }
            Console.WriteLine("{0} {1}", left + 1, right + 1);

        }
    }
}
