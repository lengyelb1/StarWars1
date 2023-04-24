using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    
    enum kardSzine { Kék, Zöld, Sárga, Lila, Piros }
    internal class Erohasznalo
    {
        string nev;
        int midiklorianok;
        kardSzine kardSzine;
        bool oldal;
        byte oldalValtoztatas = 0;
        public string Nev
        {
            get { return nev; }
            protected set
            {
                if (value.Length >= 3)
                {
                    nev = value;
                }
                else
                {
                    Console.WriteLine("A név túl rövid!");
                }
            }

        }
        public int Midiklorianok
        {
            get { return midiklorianok; }
            set
            {
                if (value >= 3000 && value < 20000)
                {
                    midiklorianok = value;
                }
                else
                {
                    Console.WriteLine("Hibás érték!");
                }
            }
        }

        public kardSzine KardSzine
        {
            get { return kardSzine; }
            set { kardSzine = value; }
        }

        public bool Oldal
        {
            get { return oldal; }
            set
            {
                if (this.oldalValtoztatas < 2)
                {
                    oldal=!oldal;
                    oldalValtoztatas++;
                }
                else
                {
                    Console.WriteLine("Többször nem lehetséges oldalt váltani!");
                }
            }
        }


        public Erohasznalo(string nev,Random rnd)
        {
            Nev = nev;
            Midiklorianok= rnd.Next(3000,20000);
            int a = rnd.Next(5);
            if (a == 4)
            {
                KardSzine = kardSzine.Piros;
                oldal = false;
            }
            else
            {
                KardSzine= (kardSzine)a;
                oldal = true;
            }
        }
    }
}
