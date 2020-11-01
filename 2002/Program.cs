using System;
using System.Collections.Generic;

namespace _2002
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

        struct User
        {
            public string password;
            public bool loogin;
        }
        static void Main(string[] args)
        {
            int n = GetNumberInt();
            Dictionary<string, User> users = new Dictionary<string, User>();
            User person;
            for (int i = 0; i < n; i++)
            {
                string answer = "";
                string[] line = Console.ReadLine().Split(' ');
                switch (line[0])
                {
                    case "register":
                        if (users.ContainsKey(line[1]))
                            answer = "fail: user already exists";
                        else
                        {
                            answer = "success: new user added";
                            person.password = line[2];
                            person.loogin = false;
                            users.Add(line[1], person);
                        }
                        break;
                    case "login":
                        if (users.ContainsKey(line[1]))
                        {
                            if (line[2] != users[line[1]].password)
                                answer = "fail: incorrect password";
                            else if (users[line[1]].loogin)
                                answer = "fail: already logged in";
                            else
                            {
                                answer = "success: user logged in";
                                person.password = users[line[1]].password;
                                person.loogin = true;
                                users[line[1]] = person;
                            }
                        }
                        else
                            answer = "fail: no such user";
                        break;
                    case "logout":
                        if (users.ContainsKey(line[1]))
                        {
                            if (users[line[1]].loogin)
                            {
                                answer = "success: user logged out";
                                person = users[line[1]];
                                person.loogin = false;
                                users[line[1]] = person;
                            }
                            else
                                answer = "fail: already logged out";
                        }
                        else
                            answer = "fail: no such user";
                        break;
                }
                Console.WriteLine(answer);
            }
        }
    }
}
