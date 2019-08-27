using System;

namespace App05Opgave100_2
{
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.NextRnd());
            Console.WriteLine(r.NextBool());
            
        }
    }

    class UdvidetRandom : System.Random
    {
        public int NextRnd()
        {
            return this.Next(1, 1002);
        }

        public bool NextBool()
        {
            return this.Next(1, 1002) < 501;
        }
    }
}
