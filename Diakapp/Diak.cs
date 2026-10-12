using System;
using System.Collections.Generic;
using System.Text;

namespace Diakapp
{
    internal class Diak
    {
        public string Nev { get; set; }
        public string Osztaly { get; set; }
        private int pontszam;
        public int Pontszam
        {
            get { return pontszam; }
            set
            {
                if (value < 0) { pontszam = 0; }
                else if (value > 100)
                {
                    pontszam = 100;
                }
                else
                {
                    pontszam = value;
                }

            }
        }
            //Konstruktor : 
            public Diak(string nev, string osztaly, int pontszam)
        {
            Nev = nev;
            Osztaly = osztaly;
            Pontszam = pontszam;

        }

        //ToString

        public override string ToString()
        {
            return $"{Nev} ({Osztaly}) - {Pontszam} pont";
        }
     }
  }

    
