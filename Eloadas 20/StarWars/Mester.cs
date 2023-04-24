using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{

    enum kopeny { kapucnis_barna, kapucnis_szürke, lenge_vaszon}
    internal class Mester:Erohasznalo
    {
        bool tanacstag;
        kopeny kopeny;
        int korabbi_tanitvanyok;

        public Mester(string nev, Random rnd) : base(nev, rnd)
        {
            Nev = nev + "Mester";
            int ksz = rnd.Next(3);
            this.kopeny = (kopeny)ksz;
            int O = rnd.Next(2);
            if (!Oldal)
            {
                Tanacstag = false;
            }
            else
            {
                if (O== 0)
                {
                    Tanacstag = false;
                }
                else
                {
                    tanacstag = true;
                }
            }
            Korabbi_tanitvanyok = rnd.Next(21);
        }

        public bool Tanacstag { get { return tanacstag; }
            private set {
                if (!tanacstag)
                {
                    tanacstag = value;
                }

            }
        }

        public kopeny Kopeny { get { return kopeny; } private set { kopeny = value;} }

        public void kopenycsere(kopeny kopeny)
        {
            this.kopeny = kopeny;
        }

        public int Korabbi_tanitvanyok
        {
            get { return korabbi_tanitvanyok; }
            set
            {
                if (value >= 0 && value <= 20)
                {
                    korabbi_tanitvanyok = value;
                }
                else
                {
                    Console.WriteLine("Hibás érték!");
                }
            }
        }

        public Mester(string nev, Random rnd, bool tanacstag, kopeny kopeny, int korabbi_tanitvanyok):base(nev,rnd)
        {
            Tanacstag = tanacstag;
            Kopeny = kopeny;
            Korabbi_tanitvanyok = korabbi_tanitvanyok;
            Nev= nev + " Mester";
        }
    }
}
