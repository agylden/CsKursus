using System;

namespace App04Opgave60_1
{
    class Program
    {
        static int LægSammen(int a, int b)
        {
            return a + b;
        }

        double BeregnAreal(int radius)
        {
            return System.Math.Pow(radius, 2) * System.Math.PI;
        }

        static void Udskriv(string txt)
        {
            Console.WriteLine(txt);
        }

        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine(res); // 7
            //double res2 = BeregnAreal(5);
            //Console.WriteLine(res2); // 78.53…
            Udskriv("Dette er en test... Og det virkede!"); // Dette er en test

            Program test = new Program();
            double resNew = test.BeregnAreal(5);
            Console.WriteLine(resNew);
        }
    }
}
