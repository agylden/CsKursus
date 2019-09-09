using System;

namespace App06Opgave120_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int res1 = Beregner(5, 4, Plus); // lægger sammen
            Console.WriteLine(res1);

            int res2 = Beregner(5, 4, Minus);	// trækker fra
            Console.WriteLine(res2);

            int res3 = Beregner(5, 4, Gange);	// trækker fra
            Console.WriteLine(res3);

            int res4 = Beregner(5, 4, Divider);	// trækker fra
            Console.WriteLine(res4);

            Console.WriteLine();
            Console.WriteLine("Mellemrum:");
            Beregn f = new Beregn(FindTilfældigFunktion());
            int res5 = f(5, 5);
            Console.WriteLine(res5);
        }

        public delegate int Beregn(int a, int b);

        public static int Beregner(int a, int b, Beregn func)
        {
            Beregn test = new Beregn(func);
            return test.Invoke(a, b);
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }

        public static Beregn FindTilfældigFunktion()
        {
            if (System.DateTime.Now.Millisecond <= 250)
                return Plus;
            if (System.DateTime.Now.Millisecond <= 500)
                return Minus;
            if (System.DateTime.Now.Millisecond <= 750)
                return Gange;
            else
                return Divider;
        }
    }
}
