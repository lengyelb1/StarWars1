using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Erohasznalo erohasznalo = new Erohasznalo("Erzsébet",rnd);
            Console.WriteLine(erohasznalo.Nev);
            Console.WriteLine(erohasznalo.Midiklorianok);
            Console.WriteLine(erohasznalo.KardSzine);
            Console.WriteLine(erohasznalo.Oldal);
            Mester mester1 = new Mester("Fekete",rnd);
            Console.WriteLine(mester1.Nev);
            Console.WriteLine(mester1.Kopeny);
            Mester mester2 = new Mester("Fehér",rnd,true,kopeny.kapucnis_barna,5);
            Console.WriteLine(mester2.Nev);
            Console.WriteLine(mester2.Tanacstag);
            Tanitvany tanitvany1 = new Tanitvany("Szöszi",rnd);
            Console.WriteLine(tanitvany1.Nev);
            Console.WriteLine(tanitvany1.TincsHossza);
            Tanitvany tanitvany2 = new Tanitvany("Kovács",rnd , 0.5,82);
            Console.WriteLine(tanitvany2.Nev);
            Console.WriteLine(tanitvany2.KardSzine);
            Rend rend = new Rend(100,20,rnd);
            Console.WriteLine(rend.Tanacstagok);
            List<Erohasznalo> erohasznalok = rend.Erohasznalok;
            List<Mester> mesterek = new List<Mester>();
            foreach (var item in erohasznalok)
            {
                if (item is Mester)
                {
                    Mester egyMester = (Mester)item;
                    if (egyMester.Kopeny == kopeny.kapucnis_szürke)
                    {
                        mesterek.Add(item as Mester);
                    }
                }
            }
            
            int index = 0;
            for (int i = 0; i < mesterek.Count; i++)
            {
                if (mesterek[i].Korabbi_tanitvanyok > mesterek[index].Korabbi_tanitvanyok)
                {
                    index = i;
                }
            }

            Console.WriteLine(index);
            Console.WriteLine(mesterek[index].Nev);
            Console.ReadKey();
        }
    }
}
