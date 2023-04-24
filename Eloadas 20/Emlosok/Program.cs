using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlosok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Halak hal = new Halak();
            hal.Nev = "Pisztráng";
            hal.Legzes = legzes.Kopoltyú;
            hal.Belso_vaz = belso_vaz.Csontos;
            hal.szaj_Elhelyezkedese = szaj_elhelyezkedese.alsó_állású;
            Halak hal2 = new Halak("cápa", belso_vaz.Porcos, legzes.Kopoltyú, szaj_elhelyezkedese.alsó_állású);

            Madarak madar = new Madarak();
            madar.Nev = "Strucc";
            madar.Belso_vaz = belso_vaz.Csontos;
            madar.Legzes = legzes.tüdő;
            madar.Feszekhagyo = true;
            madar.Repul = false;

            Emlosok emlos = new Emlosok("egér", belso_vaz.Csontos, legzes.tüdő,"rágcsáló",10);
            Console.WriteLine(emlos.Rendek);

            Elolenyek allatok = new Elolenyek();
            allatok.HozzaAd(hal);
            allatok.HozzaAd(madar);
            allatok.HozzaAd(emlos);
            List<Madarak> madarak=new List<Madarak>();
            foreach (var allat in allatok.GerincesekLista)
            {
                if (allat is Madarak)
                {
                    Console.WriteLine("madár oszály");
                    madarak.Add(allat as Madarak);
                    madarak.Add((Madarak) allat);
                }
                Console.WriteLine(allat);
            }
            Console.WriteLine(madarak.Count);
            if (hal.Equals(madar))
            {
                Console.WriteLine("Azonos a két objektum.");
            }
            else
            {
                Console.WriteLine("A két objektum eltérő!");
            }
            Halak hal3 = new Halak();
            hal3.Nev = "Pisztráng";
            hal3.Legzes = legzes.Kopoltyú;
            hal3.Belso_vaz = belso_vaz.Csontos;
            hal3.szaj_Elhelyezkedese = szaj_elhelyezkedese.alsó_állású;
            if (hal.Equals(hal3))
            {
                Console.WriteLine("Azonos a két objektum.");
            }
            else
            {
                Console.WriteLine("A két objektum eltérő!");
            }
            HashSet<Halak> halakHalmaza= new HashSet<Halak>();
            halakHalmaza.Add(hal);
            halakHalmaza.Add(hal3);
            Console.WriteLine(halakHalmaza.Count);
            Console.WriteLine(allatok.Elemszam());
            Console.ReadKey();
        }
        
    }
}
