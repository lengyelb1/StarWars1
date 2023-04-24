using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlosok
{
    internal class Elolenyek
    {
        List<Gerincesek> gerincesekLista=new List<Gerincesek>();

        public List<Gerincesek> GerincesekLista
        {
            get { return gerincesekLista; }
        }
        public void HozzaAd(Gerincesek gerinces)
        {
            GerincesekLista.Add(gerinces);
        }

        public int Elemszam()
        {
            return gerincesekLista.Count;
        }
    }
}
