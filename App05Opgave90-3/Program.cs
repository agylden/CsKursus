using System;

namespace App05Opgave90_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Fornavn = "Andreas";
            p.Efternavn = "Gylden";
            Console.WriteLine(p.Fornavn);
            Console.WriteLine(p.Efternavn);
            Console.WriteLine(p.FuldtNavn());

            Console.WriteLine("Nyt eksempel:");

            Person s = new Person();
            s.Fornavn = "je";
            s.Efternavn = "ne";
            Console.WriteLine(s.Fornavn);
            Console.WriteLine(s.Efternavn);
            Console.WriteLine(s.FuldtNavn());
        }
    }

    class Person
    {
        public string Fornavn { get; set; }
        private string _Efternavn;

        public string Efternavn
        {
            get { return _Efternavn; }
            set
            {
                if (value.Length > 3)
                {
                    _Efternavn = value;
                }
                else
                {
                    _Efternavn = "Fejl navn";
                }
            }

        }

        public string FuldtNavn()
        {
            return (this.Fornavn + " " + this.Efternavn);
        }

    }
}
