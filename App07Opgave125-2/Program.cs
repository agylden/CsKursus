using System;

namespace App07Opgave125_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kunde k = new Kunde() {Navn="Andreas",Saldo=3000 ,KreditMax = -500 };
            k.KreditMaxOverskredet += (s, e) => {
                Console.WriteLine("Kredit overskredet");
            };
            k.Køb(1000);
            k.Køb(1000);
            k.Køb(500);
            k.Køb(500);
            k.Køb(500); // Her skal metoden bundet til KreditOverskredet blive kaldt automatisk
        }
    }

    public class Kunde
    {

        public event EventHandler KreditMaxOverskredet;
        
        public string Navn { get; set; }
        public int Saldo { get; set; }
        public int KreditMax { get; set; }
        public void Køb(int værdi)
        {
            Console.WriteLine("Kunde {0} køber for {1}. Husk at der er et kreditmax på {2}", Navn, værdi, KreditMax);
            this.Saldo -= værdi;
            if (Saldo < KreditMax)
            {
                KreditMaxOverskredet?.Invoke(this, new EventArgs());
            }
        }
    }
}
