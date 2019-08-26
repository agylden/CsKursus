namespace App04Opgave80_1
{
    class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        // Default constructor
        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
        }

        public Person(string Fornavn, string Efternavn, int Fødselsår)
        {
            this.Fornavn = Fornavn;
            this.Efternavn = Efternavn;
            this.Fødselsår = Fødselsår;
        }

        public string Fuldtnavn()
        {
            return (Fornavn + " " + Efternavn);
        }

        public int Alder()
        {
            return (System.DateTime.Now.Year - Fødselsår);
        }


    }
}
