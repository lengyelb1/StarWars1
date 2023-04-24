using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlosok
{
    enum belso_vaz { Csontos, Porcos }
    enum legzes { Kopoltyú, tüdő }
    abstract class Gerincesek
    {
        string nev;
        public belso_vaz Belso_vaz;
        public legzes Legzes;

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        protected Gerincesek(string nev, belso_vaz belso_vaz, legzes legzes)
        {
            this.Nev = nev;
            Belso_vaz = belso_vaz;
            Legzes = legzes;
        }

        protected Gerincesek()
        {
        }
    }
}
