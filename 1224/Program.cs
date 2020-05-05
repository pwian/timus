using System;

namespace _1224
{
    class Program
    {
        static ulong[] GetArrayULong()
        {
            string[] line = Console.ReadLine().Split(' ');
            ulong[] array = new ulong[line.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToUInt64(line[i]);
            }
            return array;
        }

        static void Main(string[] args)
        {
            ulong[] array = GetArrayULong();
            ulong n = array[0], m = array[1];
            ulong countTurn;
            if (n == 1)
                countTurn = 0;
            else if (m == 1)
                countTurn = 1;
            else
            {
                if (n <= m)
                {
                    countTurn = 2 * (n - 2) + 1;
                    if ((countTurn + 1) / 2 != m)
                        countTurn++;
                }
                else
                {
                    countTurn = 2 * (m - 2) + 2;
                    if ((countTurn + 1) / 2 != n)
                        countTurn++;
                }
            }

            Console.WriteLine(countTurn);
        }
    }
}
