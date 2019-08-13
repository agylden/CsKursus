using System;

namespace App02Opgave40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast tal1");
            string tal1 = Console.ReadLine();
            Console.WriteLine("Indtast tal2");
            string tal2 = Console.ReadLine();

            double t1 = System.Convert.ToDouble(tal1);
            double t2 = System.Convert.ToDouble(tal2);

            double tres = t1 + t2;

            Console.WriteLine("Summen af brugerens to indtastede tal:");
            Console.WriteLine(tres.ToString("N2"));

        }
    }
}
