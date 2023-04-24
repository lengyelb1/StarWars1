using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    internal class Rend
    {
        List<Erohasznalo> erohasznalok = new List<Erohasznalo>();

        public List<Erohasznalo> Erohasznalok
        {
            get { return erohasznalok; }
        }

        public int Tanacstagok
        {
            get
            {
                int tanacstagokSzama = 0;
                foreach (var item in this.erohasznalok)
                {
                    if (item is Mester && item.Oldal)
                    {
                        Mester mester= item as Mester;
                        if (mester.Tanacstag)
                        {
                             tanacstagokSzama++;

                        }
                    }
                }
                return tanacstagokSzama;
            }
        }

        public List<Tanitvany> tanitvanyKard( kardSzine kardSzine)
        {
            List<Tanitvany> tanitvanyok = new List<Tanitvany>();

            for (int i = 0; i < this.erohasznalok.Count; i++)
            {
                if (erohasznalok[i] is Tanitvany && erohasznalok[i].Oldal)
                {
                    Tanitvany tanitvany = erohasznalok[i] as Tanitvany;
                    if (tanitvany.KardSzine == kardSzine)
                    {
                        tanitvanyok.Add(tanitvany);
                    }
                }
            }

            return tanitvanyok;
        }


        public Rend(int mersterekSzama, int tanitvanyokSzama,Random rnd)
        {
            for (int i = 0; i < mersterekSzama; i++)
            {
                Mester egymester = new Mester("Mester "+i+1.ToString(),rnd);
                erohasznalok.Add(egymester);
            }

            for (int i = 0; i < tanitvanyokSzama; i++)
            {
                Tanitvany egytanitvany = new Tanitvany("Tanitvany " + i + 1.ToString(), rnd);
                erohasznalok.Add(egytanitvany);
            }
        }

    }
}
