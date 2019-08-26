using System;

namespace App04Opgave75_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.List<int> Lst1 = new System.Collections.Generic.List<int>();
            Lst1.Add(1);
            Lst1.Add(2);
            Lst1.Add(3);
            foreach (int item in Lst1)
            {
                Console.WriteLine(item);
            }

            System.Collections.Generic.Dictionary<int, string> Dic1 = new System.Collections.Generic.Dictionary<int, string>();
            Dic1.Add(2, "Test1");
            Dic1.Add(4, "Test2");
            Dic1.Add(6, "Test3");
            string res = Dic1[6];
            Console.WriteLine(res);
        }
    }
}
