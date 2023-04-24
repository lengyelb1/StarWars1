using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    internal class Tanitvany:Erohasznalo
    {
        double tincsHossza;
        int kepzettsegiSzint;

        public Tanitvany(string nev, Random rnd) : base(nev, rnd)
        {
            Nev = "Ifjú " + nev;
            TincsHossza = rnd.NextDouble()*14.5+0.5;
        }

        public Tanitvany(string nev,Random rnd,double tincsHossza, int kepzettsegiSzint) : base(nev,rnd)
        {
            Nev = "Ifjú " + nev;
            TincsHossza = tincsHossza;
            KepzettsegiSzint = kepzettsegiSzint;
            
        }

        public double TincsHossza { get { return tincsHossza; } private set { tincsHossza = value;} }

        public int KepzettsegiSzint { get { return kepzettsegiSzint;} 
            set {
                if (value >= 0 && value <= 100)
                {
                    kepzettsegiSzint = value;
                }
                else
                {
                    Console.WriteLine("Hibás képzettségi szint érték!");
                }
            } 
        }

        


    }
}
