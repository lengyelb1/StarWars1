using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlosok
{
    enum szaj_elhelyezkedese { körszáj, végállású, felső_állású, alsó_állású, csúcsba_nyíló}
    internal class Halak : Gerincesek
    {
        public szaj_elhelyezkedese szaj_Elhelyezkedese;
        public Halak()
        {
        }

        public Halak(string nev, belso_vaz belso_vaz, legzes legzes, szaj_elhelyezkedese szaj_elhelyezkedese) : base(nev, belso_vaz, legzes)
        {
            this.szaj_Elhelyezkedese = szaj_elhelyezkedese;
        }

        public override bool Equals(object obj)
        {
            return obj is Halak halak &&
                   Belso_vaz == halak.Belso_vaz &&
                   Legzes == halak.Legzes &&
                   Nev == halak.Nev &&
                   szaj_Elhelyezkedese == halak.szaj_Elhelyezkedese;
        }
    }
}
