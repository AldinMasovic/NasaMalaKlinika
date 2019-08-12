using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
   abstract class Osoba
    {
        String ime;
        String prezime;
        int jmbg;

        public Osoba(string ime, string prezime, int jmbg)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int Jmbg { get => jmbg; set => jmbg = value; }
    }
}
