
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Diakapp;

List<Diak> lista = new List<Diak>();
int hibasSorokSzama = 0;

string[] sorok = File.ReadAllLines("eredmenyek.csv");

foreach (string sor in sorok.Skip(1))
{
    if (string.IsNullOrWhiteSpace(sor))
        continue;

    string[] adatok = sor.Split(';');

    if (adatok.Length != 3 ||
        string.IsNullOrWhiteSpace(adatok[0]) ||
        string.IsNullOrWhiteSpace(adatok[1]) ||
        !int.TryParse(adatok[2], out int pont))
    {
        hibasSorokSzama++;
        continue;
    }

    lista.Add(new Diak(adatok[0], adatok[1], pont));
}

Console.WriteLine("Diákok száma: " + lista.Count);
Console.WriteLine("Hibás sorok száma: " + hibasSorokSzama);

foreach (Diak i in lista)
{
    Console.WriteLine(i);
}

Console.ReadKey();
