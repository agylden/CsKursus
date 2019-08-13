using System;

// Implicit (fra lille til stor)
int lilleHeltal = 3000000;
long stortHeltal = lilleHeltal;
Console.WriteLine($"stortHeltal = {stortHeltal}");
double reeltTal = lilleHeltal;
Console.WriteLine($"reeltTal = {reeltTal}");

// Eksplicit (kræver hjælp)
double reeltTal2 = 4030.75;
int lilleHeltal2 = (int)reeltTal2;
Console.WriteLine($"lilleHeltal2 = {lilleHeltal2}");

// Brug af System.Convert
double reeltTal3 = 4030.75;
int lilleHeltal3 = System.Convert.ToInt32(reeltTal3);
Console.WriteLine($"lilleHeltal3 = {lilleHeltal3}");

string tal1 = "100";
int heltal = System.Convert.ToInt32(tal1);
// eller heltal = int.Parse(tal1);
Console.WriteLine($"heltal = {heltal}");

// forudsætter afvikling på en dansk maskine
string tal2 = "23,45";
double reeltTal4 = System.Convert.ToDouble(tal2);
// eller reeltTal4 = double.Parse(tal2);
Console.WriteLine($"reeltTal4 = {reeltTal4}");

string datostreng = "2012-7-23";
DateTime dato = System.Convert.ToDateTime(datostreng);
// eller dato = DateTime.Parse(datostreng);
Console.WriteLine($"dato = {dato}");

// Brug af Parse/TryParse på typer

int t1 = int.Parse("1");
// int t2 = int.Parse("1a"); // fejl

int t3;
if (int.TryParse("1", out t3))
{
    // Det gik godt
}

if (int.TryParse("1a", out int t4))
{
    // Det gik godt
}





/*
 ---------- Output: ----------

stortHeltal = 3000000
reeltTal = 3000000
lilleHeltal2 = 4030
lilleHeltal3 = 4031
heltal = 100
reeltTal4 = 23,45
dato = 23-07-2012 00:00:00

*/