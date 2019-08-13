using System;
using System.Collections.Generic;
using System.Text;

namespace App000testOnTheFly
{
    class Class2
    {
        static void Main(string[] args)
        {
            double[] nedbør = { 4, 12, 2, 8 };
            double sum = 0;
            for (int i = 0; i < nedbør.Length; i++)
                sum += nedbør[i];
            Console.WriteLine($"Sum {sum:N2}");
            double gns = sum / nedbør.Length;
            Console.WriteLine($"Gennemsnit {gns:N2}");

            /*
             ---------- Output: ----------

            Sum 26,00
            Gennemsnit 6,50

            */
        }
    }
}
