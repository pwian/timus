using System;

namespace _1149
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
            string[] A = new string[n + 1];
            for (int i = 1; i <= n; i++)
            {
                string str1 = i.ToString();
                for (int j = 1; j < i; j++)
                {
                    string str2;
                    if ((i - j) % 2 == 0)
                        str2 = (i - j) + "+" + "sin(" + str1 + ")";
                    else
                        str2 = (i - j) + "-" + "sin(" + str1 + ")";
                    str1 = str2;
                }
                A[i] = "sin(" + str1 + ")";
            }

            string str3 = A[1] + "+" + n;
            for (int i = 2; i <= n; i++)
            {
                str3 = "(" + str3 + ")" + A[i] + "+" + (n - i + 1);
            }

            Console.WriteLine(str3);


        }
    }
}
