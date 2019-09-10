using System;
using System.Collections.Generic;

namespace App07Opgave120_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Med egen Find metode
            //List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };
            //int res = a.FindIndex(0,Find);            
            //Console.WriteLine(res);

            // Med lambda (lang eksplicit syntaks)
            //List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };
            //Predicate<int> p = a1 => a1 == 51;
            //int res = a.FindIndex(0, p);
            //Console.WriteLine(res);

            // Med lambda (simpel syntaks)
            //List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };
            //int res = a.FindIndex(0, a1 => a1 == 51);
            //Console.WriteLine(res);

            // Med egen Find metode
            //List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };
            //a.ForEach(ListVærdi);

            // Med lambda (simpel syntaks)
            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };
            a.ForEach(a1 => Console.WriteLine(a1));
        }

        //static void ListVærdi(int a2)
        //{
        //    Console.WriteLine(a2);
        //}

        //static bool Find(int a1)
        //{
        //    return a1 == 51;
        //}
    }
}
