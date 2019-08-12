using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    class Aparat
    {
        String naziv;
        bool ispravan;

        public Aparat(string naziv, bool ispravan)
        {
            this.naziv = naziv;
            this.ispravan = ispravan;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public bool Ispravan { get => ispravan; set => ispravan = value; }
        public void PromjeniIspravnost() { if (ispravan) ispravan = false; else ispravan = true; }
    }
}
