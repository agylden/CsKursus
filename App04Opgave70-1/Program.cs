using System;

namespace App04Opgave70_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] månedsløn = { 10000, 20000, 15000, 20000, 30000, 15000 };
            for (int i = 0; i < månedsløn.Length; i++)
            {
                Console.WriteLine(månedsløn[i]);
            }

            double a = Gennemsnitsløn(månedsløn);
            Console.WriteLine($"Gennemsnit: {a}");
        }

        static double Gennemsnitsløn(int[] x)
        {
            int[] a = x.Clone() as int[];
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            sum /= a.Length;
            return (sum);
        }
    }
}
