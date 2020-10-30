using System;

namespace _1723
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

        static long GetNumberLong()
        {
            return Convert.ToInt64(Console.ReadLine());
        }

        static double GetNumberDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        static int PowerString(string line, string text)
        {
            int power = 0;
            int i = 0;
            while (i < line.Length)
            {
                while (i < line.Length && line[i] != text[0])
                    i++;
                if (i + text.Length <= line.Length)
                {
                    string str = line.Substring(i, text.Length);
                    if (str == text)
                        power++;
                }
                i++;
            }
            return power;
        }
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string maxLine = line[0].ToString();
            int maxPower = 1;
            for (int i = 0; i < line.Length; i++)
            {
                string text = line[i].ToString();
                int power = PowerString(line, text);
                if (power > maxPower)
                {
                    maxPower = power;
                    maxLine = text;
                    //Console.WriteLine("****text = {0}, power = {1}, maxLine = {2}", text, power, maxLine);
                }
                for (int j = i + 1; j < line.Length; j++)
                {
                    text += line[j];
                    power = PowerString(line, text);

                    if (power > maxPower)
                    {
                        maxPower = power;
                        maxLine = text;
                    }
                    //Console.WriteLine("text = {0}, power = {1}, maxLine = {2}", text, power, maxLine);
                }
            }
            Console.WriteLine(maxLine);
        }
    }
}
