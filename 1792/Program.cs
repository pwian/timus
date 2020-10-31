using System;

namespace _1792
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


        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static long GetNumberLong()
        {
            return Convert.ToInt64(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int[] array = GetArrayInt();
            bool flag1 = (array[1] + array[2] + array[3]) % 2 == array[4];
            bool flag2 = (array[0] + array[2] + array[3]) % 2 == array[5];
            bool flag3 = (array[0] + array[1] + array[3]) % 2 == array[6];
            if (!(flag1 && flag2 && flag3))
            {
                if (!flag1 && flag2 && flag3)
                    array[4] = 1 - array[4];
                else if (flag1 && !flag2 && flag3)
                    array[5] = 1 - array[5];
                else if (flag1 && flag2 && !flag3)
                    array[6] = 1 - array[6];
                else if (flag1 && !flag2 && !flag3)
                    array[0] = 1 - array[0];
                else if (!flag1 && flag2 && !flag3)
                    array[1] = 1 - array[1];
                else if (!flag1 && !flag2 && flag3)
                    array[2] = 1 - array[2];
                else if (!flag1 && !flag2 && !flag3)
                    array[3] = 1 - array[3];
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
