using System;

namespace App04Opgave60_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.IO.File.CreateText(@"c:\temp\test.txt");

            bool res = System.IO.File.Exists(@"c:\temp\test.txt");
            Console.WriteLine($"Findes fil: {res}");

            string res1 = System.IO.File.ReadAllText(@"c:\temp\test.txt");
            Console.WriteLine(res1);

            var fil = new System.IO.FileInfo(@"c:\temp\test.txt");
            DateTime d = fil.LastAccessTime;
            Console.WriteLine($"Tid: {d}");

            string f = fil.Extension;
            Console.WriteLine($"Extension er: {f}");
        }
    }
}
