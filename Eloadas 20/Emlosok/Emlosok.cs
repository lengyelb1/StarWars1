using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlosok
{
    internal class Emlosok:Gerincesek
    {
        string rendek;
        int varhato;

        public string Rendek
        {
            get { return rendek; }
            private set { rendek = value; }
        }

        public int Varhato { 
            get { return varhato; } 
            private set { varhato = value; } 
        }
        public Emlosok(string nev, belso_vaz belso_vaz, legzes legzes, string rendek, int varhato) : base(nev, belso_vaz, legzes)
        {
            Rendek = rendek;
            Varhato = varhato;
        }


        public Emlosok()
        {
        }
    }
}
