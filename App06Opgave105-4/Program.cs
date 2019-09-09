using System;
using System.Collections.Generic;

namespace App06Opgave105_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ikke muligt da class Dyr er en abstract klasse.
            //Dyr d = new Dyr();
            //d.SigNoget();

            Hund h = new Hund();
            h.SigNoget();

            Kat k = new Kat();
            k.SigNoget();

            Console.WriteLine();
            Console.WriteLine("Nyt eksempel:");

            List<Dyr> lst = new List<Dyr>();
            lst.Add(new Hund() { Navn = "Fido" });
            lst.Add(new Kat() { Navn = "Miav" });
            lst.Add(new Hund() { Navn = "Fido2" });
            lst.Add(new Kat() { Navn = "Miav2" });
            lst.Add(new Hund() { Navn = "Fido3" });
            lst.Add(new Kat() { Navn = "Miav3" });
            foreach (var item in lst)
            {
                item.SigNoget();
            }

            Console.WriteLine();

            Dyr[] d = new Dyr[20];
            for (int i = 0; i < d.Length; i++)
            {
                d[i] = Dyr.TilfældigtDyr();
            }

            foreach (Dyr item in d)
            {
                item.SigNoget();
            }
        }
    }

    abstract class Dyr
    {
        public string Navn { get; set; }
        private static System.Random rnd = new Random();

        public static Dyr TilfældigtDyr()
        {

            string data = "Freja;Bella;Emma;Mille;Fie;Molly;Lady;Trine;Trunte;Luna;Amanda;";
            data += "Bonnie;Laika;Ronja;Sally;Trille;Zita;Tøsen;Bianca;Zenta;Victor;Buller;";
            data += "Buster;King;Simba;Thor;Charlie;Samson;Bamse;Mickey;Max;Rasmus;Sofus;Anton;";
            data += "Laban;Basse;Bølle;Oliver;Oscar;Balder";
            string[] navne = data.Split(';');
            int index = rnd.Next(0, navne.Length);
            if (index % 2 == 0)
            {
                return new Hund() { Navn = navne[index] };
            }
            else
            {
                return new Kat() { Navn = navne[index] };
            }
        }

        virtual public void SigNoget()
        {
            Console.WriteLine($"Jeg er et dyr og hedder {Navn}");
        }
    }

    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine($"Jeg er en hund og hedder {Navn}");
        }
    }

    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine($"Jeg er en kat og hedder {Navn}");
        }
    }
}
