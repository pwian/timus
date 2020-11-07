using System;
using System.Collections.Generic;

namespace _2033
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

        public struct Device
        {
            public int price;
            public int count;

            public Device(int price, int count)
            {
                this.price = price;
                this.count = count;
            }
        }

        class ComparSort : Comparer<Device>
        {
            public override int Compare(Device x, Device y)
            {
                if (x.count != y.count)
                    return -x.count.CompareTo(y.count);
                return x.price.CompareTo(y.price);
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, Device> dev = new Dictionary<string, Device>();
            for (int i = 0; i < 6; i++)
            {
                string person = Console.ReadLine();
                string name = Console.ReadLine();
                int price = GetNumberInt();


                Device T = new Device(price, 1);
                if (dev.ContainsKey(name))
                {
                    T.count = dev[name].count + 1;
                    T.price = Math.Min(T.price, dev[name].price);
                    dev[name] = T;
                }
                else
                {
                    dev.Add(name, T);
                }
            }

            SortedList<Device, string> list = new SortedList<Device, string>(new ComparSort());
            foreach (var item in dev)
            {
                if (!list.ContainsKey(item.Value))
                    list.Add(item.Value, item.Key);
            }
            Console.WriteLine(list.Values[0]);

            //foreach (var item in list)
            //{
            //    Console.WriteLine("name = {0}, price = {1}, count = {2}", item.Value, item.Key.price, item.Key.count);
            //}
        }
    }
}
