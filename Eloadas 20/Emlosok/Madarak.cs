using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlosok
{ 
    internal class Madarak:Gerincesek
    {
        bool repul;
        bool feszekhagyo;
        string faj;

        public bool Repul
        {
            get { return repul; }
            set { repul = value; }
        }

        public bool Feszekhagyo
        {
            get { return feszekhagyo; }
            set { feszekhagyo = value; }
        }

        public string Faj { 
            get { return faj; } 
            set { faj = value; }
        }

        public Madarak(bool repul, bool feszekhagyo, string faj)
        {
            Repul = repul;
            Feszekhagyo = feszekhagyo;
            Faj = faj;
        }

        public Madarak()
        {
        }
    }
}
