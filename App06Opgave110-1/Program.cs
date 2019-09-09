using System;

namespace App06Opgave110_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] test = new IDbFunktioner[5];
            test[0] = new Hund();
            test[1] = new Ubåd();
            test[2] = new Ubåd();
            test[3] = new Hund();
            test[4] = new Ubåd();
            
            for (int i = 0; i < test.Length; i++)
            {
                test[i].Gem();
            }
        }
    }

    interface IDbFunktioner
    {
        void Gem();
    }

    class Hund : IDbFunktioner
    {
        public string Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer hund...");
        }
    }

    class Ubåd : IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Tubine { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer ubåd...");
        }
    }

    class Kat
    {
        public string Navn { get; set; }
        public void Gem()
        {
            Console.WriteLine("Gemmer kat...");
        }
    }
}
