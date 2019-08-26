using System;

namespace App04Opgave80_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning a = new Terning();
            Console.WriteLine("Ved brug af en ærlig terning skulle alle udfald gerne være tilfældige:");
            a.Skriv(); 
            a.Ryst();
            a.Skriv();
            a.Ryst();
            a.Skriv();
                       
            Console.WriteLine("Ved brug af snyde terning skulle alle udfald gerne blive seks: ");
            Terning b = new Terning(true);
            b.Skriv();
            b.Ryst();
            b.Skriv();
            b.Ryst();
            b.Skriv();
        }
    }

    class Terning
    {
        public int værdi;
        private bool snyd;
        private static System.Random rnd = new System.Random();

        // Default constructor
        public Terning()
        {
            this.værdi = 1;
            this.snyd = false;
        }


        // Cutom constructor
        public Terning(bool snyd)
        {
            this.værdi = 1;
            this.snyd = snyd;
            //Ryst();
        }

        public void Skriv()
        {
            Console.WriteLine($"[{this.værdi}]");
        }

        public void Ryst()
        {
            if (this.snyd == false)
            {
                this.værdi = rnd.Next(1, 7);
            }
            else
            {
                this.værdi = 6; 
            }
        }


    }
}
